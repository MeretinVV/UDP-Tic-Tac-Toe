using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace UDP_Server.Classes
{
    /// <summary>
    /// Структура с информаией об игроке
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Имя игрока
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// IP адрес игрока
        /// </summary>
        public readonly IPEndPoint Ip;

        public Player(string name, IPEndPoint ip)
        {
            Name = name;
            Ip = ip;
        }
    }
}
