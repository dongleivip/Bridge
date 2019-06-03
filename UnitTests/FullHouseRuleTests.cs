using ShowhandGame.Models;
using ShowhandGame.Rules;
using Xunit;

namespace UnitTests
{
    public class FullHouseRuleTests
    {
        [Theory]
        [InlineData("AH AD 2S 2C 5D", false)]
        [InlineData("2H 2D 2S 3C 3D", true)]
        [InlineData("JH JD JS QC QD", true)]
        [InlineData("2H 3S 4C 5D AD", false)]
        [InlineData("2H 2D 2S 2C KD", false)]
        [InlineData("2H 2D 3S 3C KD", false)]
        public void ShouldReturnTrueWhenPokerHasThreeSameCardAndAPair(string cardText, bool expected)
        {
            var rule = new FullHouseRule();

            var poker = new Player("FullHouse",cardText);
            
            Assert.Equal(expected, rule.IsMatch(poker.Cards));
        }
    }
}