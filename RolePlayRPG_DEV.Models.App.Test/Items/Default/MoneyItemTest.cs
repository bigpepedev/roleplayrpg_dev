using FluentAssertions;
using RolePlayRPG_DEV.Models.App.Item.Default;
using RolePlayRPG_DEV.Models.Base.General.Enum;

namespace RolePlayRPG_DEV.Models.App.Test.Items.Default
{
    public class MoneyItemTest
    {
        /// <summary>
        /// Comprueba que un item de tipo defensa y calidad LOW tiene el valor 5
        /// </summary>
        [Theory]
        [InlineData(QualityEnum.LOW, 10)]
        [InlineData(QualityEnum.MEDIUM, 100)]
        [InlineData(QualityEnum.RARE, 1000)]
        [InlineData(QualityEnum.EPIC, 5000)]
        [InlineData(QualityEnum.LEGEND, 10000)]
        public void MoneyItem_LOW_ValueShouldBeEquivalentAsQuality(QualityEnum quality, int result)
        {
            //Arrange
            var item = new MoneyItem(quality);
            //Act
            //Assert
            item.Value.Should().Be(result);
        }

    }
}
