using RolePlayRPG_DEV.Models.Base.General.Enum;
using RolePlayRPG_DEV.Models.Base.Item;

namespace RolePlayRPG_DEV.Models.Base.Treasure
{
    /// <summary>
    /// Modelo de un tesoro
    /// </summary>
    public class TreasureItem
    {

        /// <summary>
        /// Tipo de tesoro
        /// </summary>
        private TypeTreasureEnum Type { get; set; }

        /// <summary>
        /// Calidad del tesoro
        /// </summary>
        private QualityEnum Quality { get; set; }

        /// <summary>
        /// Total de items que puede contener
        /// </summary>
        public int NumberItems { get; set; }

        /// <summary>
        /// Lista de items que contiene el tesoro
        /// </summary>
        IList<ItemBase> ItemList { get; set; }
    }
}
