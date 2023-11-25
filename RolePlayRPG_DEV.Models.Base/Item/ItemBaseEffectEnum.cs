using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayRPG_DEV.Models.Base.Item
{
    /// <summary>
    /// Enumerador con los efectos posibles de los items de ayuda
    /// </summary>
    public enum ItemBaseEffectEnum
    {
        /// <summary>
        /// Al heroe que tiene el turno
        /// </summary>
        HEROE = 1,
        /// <summary>
        /// Al enemigo que le toca el proximo turno
        /// </summary>
        ENEMY = 2,
        /// <summary>
        /// Todos los heroes
        /// </summary>
        ALLHEROE = 3,
        /// <summary>
        /// Todos los enemigos
        /// </summary>
        ALLENEMIES = 4,
        /// <summary>
        /// Al heroe seleccionado
        /// </summary>
        SELECTHEROE = 5,
        /// <summary>
        /// Al enemigo seleccionado
        /// </summary>
        SELECTENEMY = 6,
    }
}
