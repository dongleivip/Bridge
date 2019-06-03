using System.Linq;
using ShowhandGame.Models;
using ShowhandGame.Rules;
using Xunit;

namespace UnitTests
{
    public class PairRuleTests
    {
        private readonly PairRule _rule;
        
        public PairRuleTests()
        {
            _rule = new PairRule();
        }

        [Fact]
        public void ShouldReturnFalseWhenPokerHasAnyPairCards()
        {
            var cards = "2H 3D 5S 9C KD".Split(" ").Select(text => new Card(text)).ToList();

            Assert.False(_rule.IsMatch(cards));
        }

        [Fact]
        public void ShouldReturnTrueWhenPokerHasOnePairCards()
        {
            var cards = "2H 2D 5S 9C KD".Split(" ").Select(text => new Card(text)).ToList();
            
            Assert.True(_rule.IsMatch(cards));
        }


        [Theory]
        [InlineData("2H 2D 5S 9C KD", true)]
        [InlineData("2H 2D 2S 9C KD", false)]
        [InlineData("2H 2D 2S 2C KD", false)]
        public void ShouldReturnTrueWhenPokerHasMoreThanOnePair(string cardsText, bool isExpected)
        {
            var cards = cardsText.Split(" ").Select(text => new Card(text)).ToList();
            
            Assert.Equal(isExpected, _rule.IsMatch(cards));
        }
    }
}