using System.Collections.Generic;
using System.Linq;
using ShowhandGame.Models;

namespace ShowhandGame.Rules
{
    public class StraightRule : ICategoryRule
    {
        public bool IsMatch(List<Card> cards)
        {
            var group = cards.GroupBy(x => x.ValueType);

            if (group.Count() != 5)
            {
                return false;
            }

            var sorted = cards.OrderBy(x => x.ValueType).ToList();

            for (var i = 0; i < sorted.Count() - 1; i++)
            {
                var curr = sorted[i];
                var next = sorted[i + 1];

                if (next.ValueType - curr.ValueType != 1)
                {
                    return false;
                }
            }


            return true;
        }
    }
}