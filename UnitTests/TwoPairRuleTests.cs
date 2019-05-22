using System.Linq;
using ShowhandGame.Models;
using ShowhandGame.Rules;
using Xunit;

namespace UnitTests
{
    public class TwoPairRuleTests
    {
        private TwoPairRule _rule;
        
        public TwoPairRuleTests()
        {
            _rule = new TwoPairRule();
        }

        [Theory]
        [InlineData("2H 2D 5S 9C KD", false)]
        [InlineData("4H 4D 4S 2C 4D", false)]
        [InlineData("2H 2D 2S 2C KD", false)]
        [InlineData("4H 4D 4S 2C 2D", false)]
        [InlineData("2H 2D 3S 3C KD", true)]
        public void ShouldReturnTrueWhenPokerHasTwoPairs(string cardsText, bool expected)
        {
             var cards = cardsText.Split(" ").Select(text => new Card(text)).ToList();
            
             Assert.Equal(expected,_rule.IsMatch(cards));
        }
    }
}