using System.Collections.Generic;
using System.Linq;
using ShowhandGame.Models;

namespace ShowhandGame.Rules
{
    public class StraightFlushRule : StraightRule, ICategoryRule 
    {
        public new bool IsMatch(List<Card> cards)
        {
            var isStraight = base.IsMatch(cards);

            var group = cards.GroupBy(x => x.Suit).ToList();


            var count = group.Count;

            return isStraight && cards.GroupBy(x => x.Suit).Count() == 1;
        }
    }
}