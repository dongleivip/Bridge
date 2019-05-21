using System;
using ShowhandGame.Exceptions;

namespace ShowhandGame.Models
{
    public class Card
    {
        public CardValueType ValueType { get; private set; }

        public SuitType Suit { get; private set; }

        public Card(string cardText)
        {
            if (cardText.Length != 2)
            {
                throw new InvalidCardInputException(cardText); 
            }
            
            var value = cardText[0];
            var suit = cardText[1];

            try
            {
                ValueType = (CardValueType) Enum.Parse(typeof(CardValueType), value.ToString());
                Suit = (SuitType) Enum.Parse(typeof(SuitType), suit.ToString());
            }
            catch (Exception)
            {
                throw new InvalidCardInputException(cardText);
            }
        }
    }
}