using System.Collections.Generic;
using System.Linq;
using ShowhandGame.Models;

namespace ShowhandGame.Rules
{
    public class FullHouseRule : ICategoryRule
    {
        public bool IsMatch(List<Card> cards)
        {
            var group = cards.GroupBy(x => x.ValueType).ToList();

            if (group.Count != 2)
            {
                return false;
            }

            // 8, 8, 8, 1, 2 - group = 3 - false
            // 8, 8, 8, 1, 1 - group = 2 - true
            // 8, 8, 8, 8, 1 - group = 2, but not all >= 2 - false
            
            return  group.Count > 0 && group.All(g => g.Count() >= 2);
        }

        public Category CategoryType => Category.FullHouse;
    }
}