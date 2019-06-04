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
        [InlineData("2H 2D 5S 9C KD", "AH 2D 3S 4C KD")] 
        [InlineData("2H 2D 2S 3C 3D", "2H 2D 5S 9C KD")]
        [InlineData("5S 6S 7S 8S 9S", "2H 2D 3S 3C 3D")]
        public void ShouldReturnTheWinner(string cardTextWin, string cardTextLose)
        {
            var player1 = new Player("winner", cardTextWin);
            var player2 = new Player("loser", cardTextLose);

            var winner = _judge.WhoWin(player1, player2);

            Assert.Equal("winner", winner.Name);
        }


        [Theory]
        [InlineData("AH 2D 3S 4C KD", "2H 3D 5S 9C KD")] 
        [InlineData("2H 3D 4S 5C KD", "6H 7D 8S 9C QD")] 
        [InlineData("6H 7D 8S QC KD", "6H 7D 8S TC KD")] 
        public void ShouldCompeteCardsOneByOneWhenBothPlayersAreHighCardType(string cardTextWin, string cardTextLose)
        {
            var player1 = new Player("winner", cardTextWin);
            var player2 = new Player("loser", cardTextLose);

            var winner = _judge.WhoWin(player1, player2);
            
            Assert.Equal("winner", winner.Name);
        }
    }
}