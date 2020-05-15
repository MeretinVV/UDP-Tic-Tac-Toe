using System;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using UDP_Server.Classes;
using System.Threading;

namespace UDP_Server
{
    class Program
    {
        /// <summary>
        /// Максимальное количество пользователей одновременно
        /// </summary>
        private static readonly int maxUsers = 4;
        /// <summary>
        /// Количество подключенных пользователей на данный момент 
        /// </summary>
        private static int currentUsers = 0;

        /// <summary>
        /// Обрабатываем запрос на подключение
        /// </summary>
        /// <returns>Структуру с информацией о принятом игроке</returns>
        private static Player AcceptPlayer()
        {
            start:
            using (UdpClient client = new UdpClient(8080))
            {
                IPEndPoint playerIp = null;
                byte[] data = client.Receive(ref playerIp);

                client.Connect(playerIp);
                if (currentUsers >= maxUsers)
                {
                    client.Send(new byte[1] { 0 }, 1);
                    goto start;
                }
                client.Send(new byte[1] { 1 }, 1);

                Interlocked.Increment(ref currentUsers);

                Console.WriteLine("Accepted player: " + playerIp);
                return new Player(Encoding.UTF8.GetString(data), playerIp);
            }
        }

        /// <summary>
        /// Проводим игру между игроками
        /// </summary>
        /// <param name="player1">1 игрок</param>
        /// <param name="player2">2 игрок</param>
        private static async Task PlayTheGame(Player player1, Player player2)
        {
            Console.WriteLine($"Started the game between {0} and {1}", player1.Ip, player2.Ip);

            Figure[] playField = new Figure[9];
            for (int i = 0; i < playField.Length; ++i) playField[i] = Figure.None;

            // Ждем чтобы все игроки успели начать слушать
            Thread.Sleep(500);
            using (UdpClient client1 = new UdpClient())
            using (UdpClient client2 = new UdpClient())
            {
                client1.Connect(player1.Ip);
                client2.Connect(player2.Ip);

                // Определяем роли
                client1.Send(new byte[1] { 0 }, 1);
                client2.Send(new byte[1] { 1 }, 1);

                Result res;
                while (true)
                {
                    // Получаем информацию о ходе 1 игрока
                    res = MakeMove(client1, client2, ref playField, Figure.Cross);
                    if (res != Result.None) break;

                    // Получаем информацию о ходе 2 игрока
                    res = MakeMove(client2, client1, ref playField, Figure.Circle);
                    if (res != Result.None) break;
                }

                // Говорим клиентам что игра окончена
                client1.Send(new byte[1] { 0 }, 1);
                client2.Send(new byte[1] { 0 }, 1);

                // Отправляем информацию о победителе
                if (res == Result.Draw)
                {
                    client1.Send(new byte[1] { 2 }, 1);
                    client2.Send(new byte[1] { 2 }, 1);
                }
                else
                {
                    client1.Send(new byte[1] { (byte)(res == Result.Crosses ? 1 : 0) }, 1);
                    client2.Send(new byte[1] { (byte)(res == Result.Circles ? 1 : 0) }, 1);
                }
            }
            Interlocked.Add(ref currentUsers, -2);
        }

        /// <summary>
        /// Обрабатываем ход одного из игроков
        /// </summary>
        /// <param name="player1">Игрок, который делает ход</param>
        /// <param name="player2">Игрок, который принимает ход</param>
        /// <param name="playField">Игровое поле</param>
        /// <param name="figure">Фигура, за которую играет 1 игрок</param>
        /// <returns>Результат хода</returns>
        private static Result MakeMove(UdpClient player1, UdpClient player2, 
                                       ref Figure[] playField, Figure figure)
        {
            var lastContactedIp = new IPEndPoint(IPAddress.Any, 8080);

            player1.Send(new byte[1] { 1 }, 1);
            player2.Send(new byte[1] { 1 }, 1);

            // Получаем информацию о ходе 1 игрока
            byte[] moveInfo = player1.Receive(ref lastContactedIp);
            player2.Send(new byte[1] { moveInfo[0] }, 1);
            playField[moveInfo[0]] = figure;

            return CheckTheField(playField);
        }

        /// <summary>
        /// Проверяет состояние игрового поля
        /// </summary>
        /// <param name="playField">Игровое поле</param>
        /// <returns>Результат проверки</returns>
        private static Result CheckTheField(Figure[] playField)
        {           
            // Проверяем по горизонтали
            for (int i = 0; i < playField.Length; i += 3)
            {
                if (playField[i] != Figure.None
                    && playField[i] == playField[i + 1]
                    && playField[i] == playField[i + 2])
                    return playField[i] == Figure.Cross ? Result.Crosses : Result.Circles; 
            }

            // Проверяем по вертикали
            for (int i = 0; i < playField.Length / 3; ++i)
            {
                if (playField[i] != Figure.None
                    && playField[i] == playField[i + 3]
                    && playField[i] == playField[i + 6])
                    return playField[i] == Figure.Cross ? Result.Crosses : Result.Circles;
            }

            // Проверяем по диагонали
            if (playField[0] != Figure.None
                    && playField[0] == playField[4]
                    && playField[0] == playField[8])
                return playField[0] == Figure.Cross ? Result.Crosses : Result.Circles;
            if (playField[2] != Figure.None
                    && playField[2] == playField[4]
                    && playField[2] == playField[6])
                return playField[2] == Figure.Cross ? Result.Crosses : Result.Circles;

            // Проверяем забиты ли уже все поля, если да - это ничья
            foreach (Figure field in playField) if (field == Figure.None) return Result.None;

            return Result.Draw;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Player player1 = AcceptPlayer(),
                       player2 = AcceptPlayer();

                Task.Run(() => PlayTheGame(player1, player2));
            }
        }
    }
}
