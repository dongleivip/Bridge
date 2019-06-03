using System.Collections.Generic;
using ShowhandGame.Models;

namespace ShowhandGame.Rules
{
    public interface ICategoryRule
    {
        bool IsMatch(List<Card> cards);

        Category CategoryType { get; }
    }
}