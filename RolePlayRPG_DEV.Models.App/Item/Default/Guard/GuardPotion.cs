using RolePlayRPG_DEV.Models.Base.Item;
using RolePlayRPG_DEV.Models.Base.Item.Types;

namespace RolePlayRPG_DEV.Models.App.Item.Default.Guard
{
    /// <summary>
    /// Configuración de una poción de guardia estandar
    /// </summary>
    public class GuardPotion : GuardItemBase
    {

        public GuardPotion()
        {
            Id = 1;
            Name = "Poción de guardia";
            Description = "Incrementa un 20% la defensa de un personaje";
            Type = ItemBaseTypeEnum.GUARD;
            //% de incremento de un personaje
            DefaultValue = 20;
            //Solo surte efecto sobre el heroe que tiene el turno
            Effect = ItemBaseEffectEnum.HEROE;
        }

    }
}
