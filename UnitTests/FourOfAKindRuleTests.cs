using ShowhandGame.Models;
using ShowhandGame.Rules;
using Xunit;

namespace UnitTests
{
    public class FourOfAKindRuleTests
    {
        [Theory]
        [InlineData("AH AD AS AC 5D", true)]
        [InlineData("2H 2D 2S 2C 3D", true)]
        [InlineData("JH JD JS QC QD", false)]
        [InlineData("2H 3D 4S 5C 6D", false)]
        [InlineData("2H 2D 3S 3C KD", false)]
        public void ShouldReturnTrueWhenPokerHasFourSameValueCards(string cardText, bool expected)
        {
            var rule = new FourOfAKindRule();

            var poker = new Poker("FourOfAKind", cardText);
            
            Assert.Equal(expected, rule.IsMatch(poker.Cards));
        }
    }
}