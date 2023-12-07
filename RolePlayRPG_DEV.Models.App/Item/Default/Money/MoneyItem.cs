using RolePlayRPG_DEV.Models.Base.General.Enum;
using RolePlayRPG_DEV.Models.Base.Item;

namespace RolePlayRPG_DEV.Models.App.Item.Default.Guard
{
    /// <summary>
    /// Item base de las monedicas
    /// </summary>
    public class MoneyItem : ItemBase
    {

        public MoneyItem(ItemBaseTypeEnum type, QualityEnum quality)
        {
            this.Type = type;
            this.Quality = quality;
            SetItem();
        }

        //Porcentaje a aplicar en el efecto de la poción de guardado
        private void SetItem()
        {
            this.Name = "Monedica";
            this.Description = "Monedica de cambio del juego";
            this.Effect = ItemBaseEffectEnum.NONE;
            switch (this.Quality)
            {
                case QualityEnum.LOW:
                    this.Value = 10;
                    break;
                case QualityEnum.MEDIUM:
                    this.Value = 100;
                    break;
                case QualityEnum.RARE:
                    this.Value = 1000;
                    break;
                case QualityEnum.EPIC:
                    this.Value = 5000;
                    break;
                case QualityEnum.LEGEND:
                    this.Value = 10000;
                    break;
            }
        }

    }
}
