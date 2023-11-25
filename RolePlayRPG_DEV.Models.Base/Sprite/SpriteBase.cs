using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayRPG_DEV.Models.Base.Sprite
{
    /// <summary>
    /// Modelo base para los sprites de los actores
    /// </summary>
    public class SpriteBase
    {
        /// <summary>
        /// identificador del sprite
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre del sprite
        /// </summary>
        public string Name { get; set; }    

        /// <summary>
        /// Descripción del sprite
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Imagen del sprite
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Número de orden en el que se cargan los sprites
        /// </summary>
        public int Order { get; set; }

    }
}
