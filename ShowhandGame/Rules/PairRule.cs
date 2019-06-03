using System.Collections.Generic;
using System.Linq;
using ShowhandGame.Models;

namespace ShowhandGame.Rules
{
    public class PairRule : ICategoryRule
    {
        public bool IsMatch(List<Card> cards)
        {
            var valueGroup = cards.GroupBy(c => c.ValueType);

            return valueGroup.Count() == 4;
        }

        public Category CategoryType => Category.Pair;
    }
}