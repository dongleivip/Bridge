using System.Collections.Generic;
using System.Linq;
using ShowhandGame.Rules;

namespace ShowhandGame.Models
{
    public class Judge
    {
        private readonly List<ICategoryRule> _categoryRules;

        public Judge()
        {
            _categoryRules = new List<ICategoryRule>()
            {
                new PairRule(),
                new TwoPairRule(),
                new ThreeOfAKindRule(),
                new StraightRule(),
                new FullHouseRule(),
                new FourOfAKindRule(),
                new StraightFlushRule(),
            };
        }

        public Player WhoWin(Player player1, Player player2)
        {
            player1.Category = CheckCategory(player1.Cards);
            player2.Category = CheckCategory(player2.Cards);

            if (player1.Category == player2.Category)
            {
                var cards1 = player1.Cards.OrderByDescending(x => (int) x.ValueType).ToList();
                var cards2 = player2.Cards.OrderByDescending(x => (int)x.ValueType).ToList();

                for (var index = 0; index < cards1.Count; index++)
                {
                    var highCard1 = cards1[index].ValueType;
                    var highCard2 = cards2[index].ValueType;

                    if (highCard1 == highCard2)
                    {
                        continue;
                    }

                    return highCard1 > highCard2 ? player1 : player2;
                }
                
            }

            return player1.Category > player2.Category ? player1 : player2;
        }

        private Category CheckCategory(List<Card> cards)
        {
            var rule = _categoryRules.LastOrDefault(r => r.IsMatch(cards));

            return rule?.CategoryType ?? Category.HighCard;
        }
    }
}