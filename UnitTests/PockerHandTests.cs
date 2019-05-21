using ShowhandGame.Models;
using Xunit;

namespace UnitTests
{
    public class PockerHandTests
    {

        [Fact]
        public void ShouldReturnACorrectPockerHand()
        {
            var pocker = new Poker("Black","2H 3D 5S 9C KD");
            
            Assert.Equal(5, pocker.Cards.Count);
            Assert.Equal("Black", pocker.Name);
        }
    }
}