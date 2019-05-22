using System.Collections.Generic;
using System.Linq;
using ShowhandGame.Models;

namespace ShowhandGame.Rules
{
    public class TwoPairRule : ICategoryRule
    {
        public bool IsMatch(List<Card> cards)
        {
            var group = cards.GroupBy(x => x.ValueType).ToList();

            return group.Count == 3 && group.Count(g => g.Count() == 2) == 2;
        }
    }
}