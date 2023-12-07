﻿using RolePlayRPG_DEV.Models.Base.General.Enum;
using RolePlayRPG_DEV.Models.Base.Item;

namespace RolePlayRPG_DEV.Models.App.Item.Default.Guard
{
    /// <summary>
    /// Item base de una poción de velocidad
    /// </summary>
    public class SpeedItem : ItemBase
    {

        public SpeedItem(ItemBaseTypeEnum type, QualityEnum quality)
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
                    this.Name = "Poción pequeña de velocidad";
                    this.Description = "Poción pequeña que incrementa un 5% la velocidad del personaje";
                    this.Effect = ItemBaseEffectEnum.HEROE;
                    this.Value = 5;
                    break;
                case QualityEnum.MEDIUM:
                    this.Name = "Poción de velocidad";
                    this.Description = "Poción que incrementa un 10% la velocidad del personaje";
                    this.Effect = ItemBaseEffectEnum.HEROE;
                    this.Value = 10;
                    break;
                case QualityEnum.RARE:
                    this.Name = "Poción de velocidad grande";
                    this.Description = "Poción grande que incrementa un 15% la velocidad del personaje";
                    this.Effect = ItemBaseEffectEnum.HEROE;
                    this.Value = 15;
                    break;
                case QualityEnum.EPIC:
                    this.Name = "Poción de velocidad epica";
                    this.Description = "Poción epica que incrementa un 25% la velocidad del personaje";
                    this.Effect = ItemBaseEffectEnum.ALLHEROE;
                    this.Value = 25;
                    break;
                case QualityEnum.LEGEND:
                    this.Name = "Poción de velocidad legendaria";
                    this.Description = "Poción legendaria que incrementa un 50% la velocidad del personaje";
                    this.Effect = ItemBaseEffectEnum.ALLHEROE;
                    this.Value = 50;
                    break;
            }
        }

    }
}