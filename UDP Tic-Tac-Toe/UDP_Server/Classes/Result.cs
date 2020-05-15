using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDP_Server.Classes
{
    /// <summary>
    /// Отображает результат игры
    /// </summary>
    public enum Result
    {
        /// <summary>
        /// Победа крестиков
        /// </summary>
        Crosses,
        /// <summary>
        /// Победа ноликов
        /// </summary>
        Circles,
        /// <summary>
        /// Ничья
        /// </summary>
        Draw,
        /// <summary>
        /// Игра не закончена
        /// </summary>
        None
    }
}
