using RolePlayRPG_DEV.Models.Base.General.Enum;
using RolePlayRPG_DEV.Models.Base.Item;

namespace RolePlayRPG_DEV.Models.App.Item.Default
{
    /// <summary>
    /// Item base de una poción de defensa
    /// </summary>
    public class GuardItem : ItemBase
    {

        public GuardItem(QualityEnum quality)
        {
            Type = ItemBaseTypeEnum.GUARD;
            Quality = quality;
            SetItem();
        }

        //Porcentaje a aplicar en el efecto de la poción de guardado
        private void SetItem()
        {
            switch (Quality)
            {
                case QualityEnum.LOW:
                    Name = "Poción pequeña de defensa";
                    Description = "Poción pequeña que incrementa un 5% la defensa del personaje";
                    Effect = ItemBaseEffectEnum.HEROE;
                    Value = 5;
                    break;
                case QualityEnum.MEDIUM:
                    Name = "Poción de defensa";
                    Description = "Poción  que incrementa un 10% la defensa del personaje";
                    Effect = ItemBaseEffectEnum.HEROE;
                    Value = 10;
                    break;
                case QualityEnum.RARE:
                    Name = "Poción de defensa grande";
                    Description = "Poción grande que incrementa un 15% la defensa del personaje";
                    Effect = ItemBaseEffectEnum.HEROE;
                    Value = 15;
                    break;
                case QualityEnum.EPIC:
                    Name = "Poción de defensa epica";
                    Description = "Poción epica que incrementa un 25% la defensa del personaje";
                    Effect = ItemBaseEffectEnum.ALLHEROE;
                    Value = 25;
                    break;
                case QualityEnum.LEGEND:
                    Name = "Poción de defensa legendaria";
                    Description = "Poción legendaria que incrementa un 50% la defensa del personaje";
                    Effect = ItemBaseEffectEnum.ALLHEROE;
                    Value = 50;
                    break;
            }
        }

    }
}
