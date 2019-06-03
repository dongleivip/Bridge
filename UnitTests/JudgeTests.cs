using ShowhandGame.Models;
using Xunit;

namespace UnitTests
{
    public class JudgeTests
    {
        private Judge _judge;
        
        public JudgeTests()
        {
            _judge = new Judge();
        }

        [Theory]
        [InlineData("2H 2D 5S 9C KD", "1H 2D 3S 4C KD")] 
        [InlineData("2H 2D 2S 3C 3D", "2H 2D 5S 9C KD")]
        [InlineData("5S 6S 7S 8S 9S", "2H 2D 3S 3C 3D")]
        public void ShouldReturnTheWinner(string cardTextWin, string cardTextLose)
        {
            var player1 = new Player("winner", cardTextWin);
            var player2 = new Player("loser", cardTextLose);

            var winner = _judge.WhoWin(player1, player2);

            Assert.Equal(player1.Name, winner.Name);
        }
    }
}