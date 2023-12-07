using RolePlayRPG_DEV.Models.Base.General.Enum;
using RolePlayRPG_DEV.Models.Base.Item;

namespace RolePlayRPG_DEV.Models.App.Item.Default.Guard
{
    /// <summary>
    /// Item base de una poción de fuerza
    /// </summary>
    public class StrongItem : ItemBase
    {

        public StrongItem(ItemBaseTypeEnum type, QualityEnum quality)
        {            
            this.Type = type;            
            this.Quality = quality;
            SetItem();
        }

        //Porcentaje a aplicar en el efecto de la poción de guardado
        private void SetItem()
        {
            switch (this.Quality)
            {
                case QualityEnum.LOW:
                    this.Name = "Poción pequeña de fuerza";
                    this.Description = "Poción pequeña que incrementa un 5% la fuerza del personaje";
                    this.Effect = ItemBaseEffectEnum.HEROE;
                    this.Value = 5;
                    break;
                case QualityEnum.MEDIUM:
                    this.Name = "Poción de fuerza";
                    this.Description = "Poción que incrementa un 10% la fuerza del personaje";
                    this.Effect = ItemBaseEffectEnum.HEROE;
                    this.Value = 10;
                    break;
                case QualityEnum.RARE:
                    this.Name = "Poción de fuerza grande";
                    this.Description = "Poción grande que incrementa un 15% la fuerza del personaje";
                    this.Effect = ItemBaseEffectEnum.HEROE;
                    this.Value = 15;
                    break;
                case QualityEnum.EPIC:
                    this.Name = "Poción de fuerza epica";
                    this.Description = "Poción epica que incrementa un 25% la fuerza del personaje";
                    this.Effect = ItemBaseEffectEnum.ALLHEROE;
                    this.Value = 25;
                    break;
                case QualityEnum.LEGEND:
                    this.Name = "Poción de fuerza legendaria";
                    this.Description = "Poción legendaria que incrementa un 50% la fuerza del personaje";
                    this.Effect = ItemBaseEffectEnum.ALLHEROE;
                    this.Value = 50;
                    break;
            }
        }

    }
}
