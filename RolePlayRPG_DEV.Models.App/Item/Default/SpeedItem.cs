using RolePlayRPG_DEV.Models.Base.General.Enum;
using RolePlayRPG_DEV.Models.Base.Item;

namespace RolePlayRPG_DEV.Models.App.Item.Default
{
    /// <summary>
    /// Item base de una poción de velocidad
    /// </summary>
    public class SpeedItem : ItemBase
    {

        public SpeedItem(QualityEnum quality)
        {
            Type = ItemBaseTypeEnum.SPEED;
            Quality = quality;
            SetItem();
        }

        //Porcentaje a aplicar en el efecto de la poción de guardado
        private void SetItem()
        {
            switch (Quality)
            {
                case QualityEnum.LOW:
                    Name = "Poción pequeña de velocidad";
                    Description = "Poción pequeña que incrementa un 5% la velocidad del personaje";
                    Effect = ItemBaseEffectEnum.HEROE;
                    Value = 5;
                    break;
                case QualityEnum.MEDIUM:
                    Name = "Poción de velocidad";
                    Description = "Poción que incrementa un 10% la velocidad del personaje";
                    Effect = ItemBaseEffectEnum.HEROE;
                    Value = 10;
                    break;
                case QualityEnum.RARE:
                    Name = "Poción de velocidad grande";
                    Description = "Poción grande que incrementa un 15% la velocidad del personaje";
                    Effect = ItemBaseEffectEnum.HEROE;
                    Value = 15;
                    break;
                case QualityEnum.EPIC:
                    Name = "Poción de velocidad epica";
                    Description = "Poción epica que incrementa un 25% la velocidad del personaje";
                    Effect = ItemBaseEffectEnum.ALLHEROE;
                    Value = 25;
                    break;
                case QualityEnum.LEGEND:
                    Name = "Poción de velocidad legendaria";
                    Description = "Poción legendaria que incrementa un 50% la velocidad del personaje";
                    Effect = ItemBaseEffectEnum.ALLHEROE;
                    Value = 50;
                    break;
            }
        }

    }
}
