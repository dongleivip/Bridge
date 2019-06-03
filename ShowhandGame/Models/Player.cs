using System.Collections.Generic;
using System.Linq;

namespace ShowhandGame.Models
{
    public class Player
    {
        public Player()
        {
            Cards = new List<Card>();
            Category = Category.HighCard;
        }
        
        
        public Player(string name, string inputCards)
        {
            Name = name;
            
            var cards = inputCards.Split(" ");

            Cards = cards.Select(cardText => new Card(cardText)).ToList();
        }
        
        public string Name { get; set; }
       
        public List<Card> Cards { get; private set; }

        public Category Category { get; set; }

        private Category GetCategory()
        {
            return Category.HighCard;
        }
    }
}