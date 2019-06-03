using System.Collections.Generic;
using System.Linq;
using ShowhandGame.Models;

namespace ShowhandGame.Rules
{
    public class ThreeOfAKindRule : ICategoryRule
    {
        public bool IsMatch(List<Card> cards)
        {
            var group = cards.GroupBy(x => x.ValueType).ToList();

            // 8, 8, 8, 1, 2
            // 8, 8, 1, 1, 2
            return group.Count() == 3 && group.Any(x => x.Count() == 3);
        }

        public Category CategoryType => Category.ThreeOfAKind;
    }
}