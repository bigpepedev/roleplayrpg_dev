using RolePlayRPG_DEV.Models.Base.General.Enum;
using RolePlayRPG_DEV.Models.Base.Item;

namespace RolePlayRPG_DEV.Models.App.Item.Default
{
    /// <summary>
    /// Item base de una poción de veneno
    /// </summary>
    public class VenomItem : ItemBase
    {

        public VenomItem(QualityEnum quality)
        {
            Type = ItemBaseTypeEnum.VENOM;
            Quality = quality;
            SetItem();
        }

        //Porcentaje a aplicar en el efecto de la poción de guardado
        private void SetItem()
        {
            switch (Quality)
            {
                case QualityEnum.LOW:
                    Name = "Poción pequeña de veneno";
                    Description = "Poción pequeña que reduce un 5% la salud del enemigo";
                    Effect = ItemBaseEffectEnum.ENEMY;
                    Value = 5;
                    break;
                case QualityEnum.MEDIUM:
                    Name = "Poción de veneno";
                    Description = "Poción que reduce un 10% la salud del enemigo";
                    Effect = ItemBaseEffectEnum.ENEMY;
                    Value = 10;
                    break;
                case QualityEnum.RARE:
                    Name = "Poción de veneno grande";
                    Description = "Poción grande que reduce un 15% la salud del enemigo";
                    Effect = ItemBaseEffectEnum.ENEMY;
                    Value = 15;
                    break;
                case QualityEnum.EPIC:
                    Name = "Poción de veneno epica";
                    Description = "Poción epica que reduce un 25% la salud del enemigo";
                    Effect = ItemBaseEffectEnum.ENEMY;
                    Value = 25;
                    break;
                case QualityEnum.LEGEND:
                    Name = "Poción de veneno legendaria";
                    Description = "Poción legendaria que reduce un 50% la salud de todos los enemigos";
                    Effect = ItemBaseEffectEnum.ALLENEMIES;
                    Value = 50;
                    break;
            }
        }

    }
}
