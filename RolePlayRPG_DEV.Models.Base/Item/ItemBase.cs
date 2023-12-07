using RolePlayRPG_DEV.Models.Base.General.Enum;
using RolePlayRPG_DEV.Models.Base.Sprite.Item;

namespace RolePlayRPG_DEV.Models.Base.Item
{
    /// <summary>
    /// Modelo de los item
    /// </summary>
    public class ItemBase
    {        
        /// <summary>
        /// Nombre
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Descripcion
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Tipo de item
        /// </summary>
        public ItemBaseTypeEnum Type { get; set; }

        /// <summary>
        /// Efecto del item
        /// </summary>
        public ItemBaseEffectEnum Effect { get; set; }

        /// <summary>
        /// Calidad del item
        /// </summary>
        public QualityEnum Quality { get; set; }

        /// <summary>
        /// Valor que se aplica a los items en sus respectivos usos
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Lista de imagenes asociadas al item
        /// </summary>
        public IList<ItemSpriteBase> SpriteList { get; set; }
    }
}
