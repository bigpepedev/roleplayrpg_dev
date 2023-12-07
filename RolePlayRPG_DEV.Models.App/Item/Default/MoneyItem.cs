using RolePlayRPG_DEV.Models.Base.General.Enum;
using RolePlayRPG_DEV.Models.Base.Item;

namespace RolePlayRPG_DEV.Models.App.Item.Default
{
    /// <summary>
    /// Item base de las monedicas
    /// </summary>
    public class MoneyItem : ItemBase
    {

        public MoneyItem(QualityEnum quality)
        {
            Type = ItemBaseTypeEnum.MONEY;
            Quality = quality;
            SetItem();
        }

        //Porcentaje a aplicar en el efecto de la poción de guardado
        private void SetItem()
        {
            Name = "Monedica";
            Description = "Monedica de cambio del juego";
            Effect = ItemBaseEffectEnum.NONE;
            switch (Quality)
            {
                case QualityEnum.LOW:
                    Value = 10;
                    break;
                case QualityEnum.MEDIUM:
                    Value = 100;
                    break;
                case QualityEnum.RARE:
                    Value = 1000;
                    break;
                case QualityEnum.EPIC:
                    Value = 5000;
                    break;
                case QualityEnum.LEGEND:
                    Value = 10000;
                    break;
            }
        }

    }
}
