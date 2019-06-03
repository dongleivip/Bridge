using System.Collections.Generic;
using System.Linq;
using ShowhandGame.Models;

namespace ShowhandGame.Rules
{
    public class FourOfAKindRule : ICategoryRule
    {
        public bool IsMatch(List<Card> cards)
        {
            return cards.GroupBy(x => x.ValueType).Any(g => g.Count() == 4);
        }

        public Category CategoryType => Category.FourOfAKind;
    }
}