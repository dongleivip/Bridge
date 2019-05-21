using System.Collections.Generic;

namespace ShowhandGame.Models
{
    public class PokerHand
    {
        public PokerHand()
        {
            Cards = new List<Card>();
        }
        
        public List<Card> Cards { get; set; }

        public Category Category { get; private set; }

        private Category GetCategory()
        {
            return Category.HighCard;
        }

    }
}