using System.Collections.Generic;
using System.Linq;
using ShowhandGame.Models;

namespace ShowhandGame.Rules
{
    public class TwoPairRule : ICategoryRule
    {
        public bool IsMatch(List<Card> cards)
        {
            return cards.GroupBy(x => x.ValueType).Count() == 3;
        }
    }
}