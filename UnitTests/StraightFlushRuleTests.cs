using ShowhandGame.Models;
using ShowhandGame.Rules;
using Xunit;

namespace UnitTests
{
    public class StraightFlushRuleTests
    {
        private StraightFlushRule _rule;

        public StraightFlushRuleTests()
        {
            _rule = new StraightFlushRule();
        }

        [Theory]
        [InlineData("AH KH JH QH TH", true)]
        [InlineData("4D 5D 6D 7D 8D", true)]
        [InlineData("5S 6S 7S 8S 9S", true)]
        [InlineData("7C 8C 9C TC JC", true)]
        [InlineData("6D 7D 8D 9C TD", false)]
        [InlineData("2H 3H 4H 5H AH", false)]
        [InlineData("2H 3H 4H 5H 6D", false)]
        public void ShouldReturnTrueWhenPokerHasAllCardsWithSameSuit(string cardText, bool expected)
        {
            var cards = new Poker("Flush", cardText).Cards;
            
            Assert.Equal(expected, _rule.IsMatch(cards));
        }
    }
}