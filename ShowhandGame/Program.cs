using System;
using ShowhandGame.Models;

namespace ShowhandGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Showhand Game!");

            // Input: Black: `2H 3D 5S 9C KD` White: `2C 3H 4S 8C AH` 
            // Output: White wins - high card: Ace 

            // Input: Black: `2H 4S 4C 2D 4H` White: `2S 8S AS QS 3S` 
            // Output: Black wins - full house 

            // Input: Black: `2H 3D 5S 9C KD` White: `2C 3H 4S 8C KH` 
            // Output: Black wins - high card: 9 

            // Input: Black: `2H 3D 5S 9C KD` White: `2D 3H 5C 9S KH`
            // Output: Tie

            var judge = new Judge();

            Console.WriteLine("Black: `2H 3D 5S 9C KD` White: `2C 3H 4S 8C AH` ");
            var play1 = new Player("Black", "2H 3D 5S 9C KD");
            var play2 = new Player("While", "2C 3H 4S 8C AH");

            var winner = judge.WhoWin(play1, play2);
            Console.WriteLine($"{winner.Name} wins - {winner.Category.ToString()}");
        }
    }
}