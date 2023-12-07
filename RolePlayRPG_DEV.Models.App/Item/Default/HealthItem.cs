using RolePlayRPG_DEV.Models.Base.General.Enum;
using RolePlayRPG_DEV.Models.Base.Item;

namespace RolePlayRPG_DEV.Models.App.Item.Default
{
    /// <summary>
    /// Item base de una poción de salud
    /// </summary>
    public class HealthItem : ItemBase
    {

        public HealthItem(QualityEnum quality)
        {
            Type = ItemBaseTypeEnum.HEALTH;
            Quality = quality;
            SetItem();
        }

        //Porcentaje a aplicar en el efecto de la poción de guardado
        private void SetItem()
        {
            switch (Quality)
            {
                case QualityEnum.LOW:
                    Name = "Poción pequeña de salud";
                    Description = "Poción pequeña que incrementa un 5% la salud del personaje";
                    Effect = ItemBaseEffectEnum.HEROE;
                    Value = 5;
                    break;
                case QualityEnum.MEDIUM:
                    Name = "Poción de salud";
                    Description = "Poción que incrementa un 10% la salud del personaje";
                    Effect = ItemBaseEffectEnum.HEROE;
                    Value = 10;
                    break;
                case QualityEnum.RARE:
                    Name = "Poción de salud grande";
                    Description = "Poción grande que incrementa un 15% la salud del personaje";
                    Effect = ItemBaseEffectEnum.HEROE;
                    Value = 15;
                    break;
                case QualityEnum.EPIC:
                    Name = "Poción de salud epica";
                    Description = "Poción epica que incrementa un 25% la salud del personaje";
                    Effect = ItemBaseEffectEnum.ALLHEROE;
                    Value = 25;
                    break;
                case QualityEnum.LEGEND:
                    Name = "Poción de salud legendaria";
                    Description = "Poción legendaria que incrementa un 50% la salud del personaje";
                    Effect = ItemBaseEffectEnum.ALLHEROE;
                    Value = 50;
                    break;
            }
        }

    }
}
