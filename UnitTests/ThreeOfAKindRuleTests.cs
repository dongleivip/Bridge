using ShowhandGame.Models;
using ShowhandGame.Rules;
using Xunit;

namespace UnitTests
{
    public class ThreeOfAKindRuleTests
    {
        private ThreeOfAKindRule _rule;
        
        public ThreeOfAKindRuleTests()
        {
            _rule = new ThreeOfAKindRule();    
        }

        [Theory]
        [InlineData("1H 2D 3S 4C KD", false)]
        [InlineData("2H 2D 3S 4C 5D", false)]
        [InlineData("2H 2D 3S 3C KD", false)]
        [InlineData("2H 2D 2S 3C 4D", true)]
        [InlineData("2H 2D 2S 2C KD", false)]
        public void ShouldReturnTrueWhenHasThreeSameValueCards(string cardText, bool expected)
        {
            var poker = new Player("Test" ,cardText);
            
            Assert.Equal(expected, _rule.IsMatch(poker.Cards));
        }
    }
}