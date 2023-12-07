using FluentAssertions;
using RolePlayRPG_DEV.Models.App.Item.Default;
using RolePlayRPG_DEV.Models.Base.General.Enum;

namespace RolePlayRPG_DEV.Models.App.Test.Items.Default
{
    public class StrongItemTest
    {
        /// <summary>
        /// Comprueba que un item de tipo defensa y calidad LOW tiene el valor 5
        /// </summary>
        [Theory]
        [InlineData(QualityEnum.LOW, 5)]
        [InlineData(QualityEnum.MEDIUM, 10)]
        [InlineData(QualityEnum.RARE, 15)]
        [InlineData(QualityEnum.EPIC, 25)]
        [InlineData(QualityEnum.LEGEND, 50)]
        public void StrongItem_LOW_ValueShouldBeEquivalentAsQuality(QualityEnum quality, int result)
        {
            //Arrange
            var item = new StrongItem(quality);
            //Act
            //Assert
            item.Value.Should().Be(result);
        }

    }
}
