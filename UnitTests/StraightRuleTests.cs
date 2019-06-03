using ShowhandGame.Models;
using ShowhandGame.Rules;
using Xunit;

namespace UnitTests
{
    public class StraightRuleTests
    {
        private StraightRule _rule;

        public StraightRuleTests()
        {
            _rule = new StraightRule();
        }

        [Theory]
        [InlineData("1H 2D 3S 4C 5D", true)]
        [InlineData("2H 3D 4S 5C 6D", true)]
        [InlineData("9H TD JS QC KD", true)]
        [InlineData("TH JD QS KC AD", true)]
        [InlineData("2H 3S 4C 5D AD", false)]
        [InlineData("2H 2D 2S 2C KD", false)]
        [InlineData("2H 2D 3S 3C KD", false)]
        public void ShouldReturnTrueWhenPokerHasFiveConsecutiveValues(string cardText, bool expected)
        {
            var poker = new Player("Test", cardText);
            
            Assert.Equal(expected, _rule.IsMatch(poker.Cards));
        }
    }
}