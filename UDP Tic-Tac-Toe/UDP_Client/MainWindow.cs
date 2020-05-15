using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Diagnostics;

namespace UDP_Client
{
    public partial class Client : Form
    {
        /// <summary>
        /// Начальный порт, от которого мы будем отсчитывать и брать новые порты
        /// </summary>
        private static int startingPort = 8080;
        /// <summary>
        /// IP адрес сервера
        /// </summary>
        private IPEndPoint endPoint = new IPEndPoint(IPAddress.Loopback, 8080);
        /// <summary>
        /// Ивент для получения информации о ходе в асинхронной игре
        /// </summary>
        private AutoResetEvent moveMadeEvent = new AutoResetEvent(false);
        /// <summary>
        /// Игровое поле
        /// </summary>
        private PictureBox[] playField;
        /// <summary>
        /// Изображение нолика
        /// </summary>
        private Image circle => Properties.Resources.circle;
        /// <summary>
        /// Изображение крестика
        /// </summary>
        private Image cross => Properties.Resources.cross;

        /// <summary>
        /// ID этого приложения (нужно для выдачи уникального порта)
        /// </summary>
        private int clientId;
        /// <summary>
        /// Клиент этого пользователя
        /// </summary>
        private UdpClient client;
        /// <summary>
        /// Номер клетки, в которой был сделан ход
        /// </summary>
        private byte moveIndex;

        public Client()
        {
            InitializeComponent();
            playField = PlayfieldGrpBox.Controls.OfType<PictureBox>().Reverse().ToArray();

            // Выдаем уникальный порт
            string processName = Process.GetCurrentProcess().ProcessName;
            clientId = Process.GetProcesses().Count(p => p.ProcessName == processName);
        }

        /// <summary>
        /// При нажатии на кнопку подключения
        /// </summary>
        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            if(NameTxtBox.Text == string.Empty)
            {
                MessageBox.Show("Name can't be empty!");
                return;
            }

            byte[] answer;
            using (client = new UdpClient(startingPort + clientId))
            using (MemoryStream memory = new MemoryStream())
            using (StreamWriter writer = new StreamWriter(memory))
            {
                writer.Write(NameTxtBox.Text );
                writer.Flush();
                byte[] data = memory.ToArray();
                client.Connect(endPoint);
                client.Send(data, data.Length);
                answer = client.Receive(ref endPoint);
            }

            if (answer[0] == 1)
            {
                StatusLbl.Text = "Waiting for opponent";

                NameTxtBox.Enabled = false;
                ConnectBtn.Enabled = false;

                Task.Run(() => Play());
            }
            else if (answer[0] == 0) StatusLbl.Text = "Server is busy, try again later";
        }

        /// <summary>
        /// Проводим игру
        /// </summary>
        private void Play()
        {
            IPEndPoint hostIp = null;
            Image mySymbol, opponentSymbol;

            using (client = new UdpClient(startingPort + clientId))
            {
                byte[] data = client.Receive(ref hostIp);
                client.Connect(hostIp);
                mySymbol = data[0] == 0 ? cross : circle;
                opponentSymbol = data[0] == 0 ? circle : cross;

                bool myTurn = data[0] == 0;

                // 1 значит продолжаем играть, 0 что заканчиваем
                while (client.Receive(ref hostIp)[0] == 1)
                {
                    if (myTurn)
                    {
                        Invoke(new MethodInvoker(() => {
                            PlayfieldGrpBox.Enabled = true;
                            StatusLbl.Text = "Your turn";
                        }));
                        moveMadeEvent.WaitOne();

                        Invoke(new MethodInvoker(() => playField[moveIndex].Image = mySymbol));
                        client.Send(new byte[1] { moveIndex }, 1);
                        myTurn = false;
                    }
                    else
                    {
                        Invoke(new MethodInvoker(() => {
                            PlayfieldGrpBox.Enabled = false;
                            StatusLbl.Text = "Opponent's turn";
                        }));
                        moveIndex = client.Receive(ref hostIp)[0];

                        Invoke(new MethodInvoker(() => playField[moveIndex].Image = opponentSymbol));
                        myTurn = true;
                    }
                }

                // Заканчиваем игру
                data = client.Receive(ref hostIp);
                if (data[0] == 2) MessageBox.Show("It's a draw!");
                else MessageBox.Show(data[0] == 0 ? "You've lost =(" : "You've won!");
                Invoke(new MethodInvoker(() =>
                {
                    foreach (PictureBox field in playField) field.Image = null;
                    PlayfieldGrpBox.Enabled = false;
                    ConnectBtn.Enabled = true;
                    NameTxtBox.Enabled = true;
                    StatusLbl.Text = "Disconnected";
                }));
            }
        }

        /// <summary>
        /// При нажатии на клетку во время игры
        /// </summary>
        private void Field_Click(object sender, EventArgs e)
        {
            PictureBox field = (PictureBox)sender;
            if (field.Image != null) return;

            moveIndex = byte.Parse(field.Name.Remove(0, 5));
            moveMadeEvent.Set();
        }
    }
}
