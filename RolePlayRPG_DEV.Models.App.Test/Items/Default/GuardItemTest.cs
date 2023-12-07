using FluentAssertions;
using RolePlayRPG_DEV.Models.App.Item.Default.Guard;
using RolePlayRPG_DEV.Models.Base.General.Enum;
using RolePlayRPG_DEV.Models.Base.Item;

namespace RolePlayRPG_DEV.Models.App.Test.Items.Default
{
    public class GuardItemTest
    {
        /// <summary>
        /// Comprueba que un item de tipo defensa y calidad LOW tiene el valor 5
        /// </summary>
        [Theory]
        [InlineData(ItemBaseTypeEnum.GUARD, QualityEnum.LOW, 5)]
        [InlineData(ItemBaseTypeEnum.GUARD, QualityEnum.MEDIUM, 10)]
        [InlineData(ItemBaseTypeEnum.GUARD, QualityEnum.RARE, 15)]
        [InlineData(ItemBaseTypeEnum.GUARD, QualityEnum.EPIC, 25)]
        [InlineData(ItemBaseTypeEnum.GUARD, QualityEnum.LEGEND, 50)]
        public void GuardItem_LOW_ValueShouldBeEquivalentAsQuality(ItemBaseTypeEnum type, QualityEnum quality, int result)
        {
            //Arrange
            var guardItem = new GuardItem(type, quality);
            //Act
            //Assert
            guardItem.Value.Should().Be(result);
        }

    }
}
