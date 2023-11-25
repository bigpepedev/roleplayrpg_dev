using RolePlayRPG_DEV.Models.Base.Item;
using RolePlayRPG_DEV.Models.Base.Item.Types;

namespace RolePlayRPG_DEV.Models.App.Item.Default.Money
{
    /// <summary>
    /// Configuración por defecto de una moneda
    /// </summary>
    public class MoneyItem : MoneyItemBase
    {

        public MoneyItem()
        {
            Id = 1;
            Name = "Monedica";
            Description = "Moneda que se usa en el juego para el comercio";
            Type = ItemBaseTypeEnum.MONEY;
            DefaultValue = 1;
        }

    }
}
