using RolePlayRPG_DEV.Models.Base.General.Enum;
using RolePlayRPG_DEV.Models.Base.Item;

namespace RolePlayRPG_DEV.Models.App.Item.Default.Guard
{
    /// <summary>
    /// Item base de una poción de veneno
    /// </summary>
    public class VenomItem : ItemBase
    {

        public VenomItem(ItemBaseTypeEnum type, QualityEnum quality)
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
                    this.Name = "Poción pequeña de veneno";
                    this.Description = "Poción pequeña que reduce un 5% la salud del enemigo";
                    this.Effect = ItemBaseEffectEnum.ENEMY;
                    this.Value = 5;
                    break;
                case QualityEnum.MEDIUM:
                    this.Name = "Poción de veneno";
                    this.Description = "Poción que reduce un 10% la salud del enemigo";
                    this.Effect = ItemBaseEffectEnum.ENEMY;
                    this.Value = 10;
                    break;
                case QualityEnum.RARE:
                    this.Name = "Poción de veneno grande";
                    this.Description = "Poción grande que reduce un 15% la salud del enemigo";
                    this.Effect = ItemBaseEffectEnum.ENEMY;
                    this.Value = 15;
                    break;
                case QualityEnum.EPIC:
                    this.Name = "Poción de veneno epica";
                    this.Description = "Poción epica que reduce un 25% la salud del enemigo";
                    this.Effect = ItemBaseEffectEnum.ENEMY;
                    this.Value = 25;
                    break;
                case QualityEnum.LEGEND:
                    this.Name = "Poción de veneno legendaria";
                    this.Description = "Poción legendaria que reduce un 50% la salud de todos los enemigos";
                    this.Effect = ItemBaseEffectEnum.ALLENEMIES;
                    this.Value = 50;
                    break;
            }
        }

    }
}
