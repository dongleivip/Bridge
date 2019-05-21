using System.Collections.Generic;
using System.Linq;

namespace ShowhandGame.Models
{
    public class Poker
    {
        public Poker()
        {
            Cards = new List<Card>();
            Category = Category.HighCard;
        }
        
        
        public Poker(string name, string inputCards)
        {
            Name = name;
            
            var cards = inputCards.Split(" ");

            Cards = cards.Select(cardText => new Card(cardText)).ToList();
        }
        
        public string Name { get; set; }
       
        public List<Card> Cards { get; private set; }

        public Category Category { get; private set; }

        private Category GetCategory()
        {
            return Category.HighCard;
        }

    }
}