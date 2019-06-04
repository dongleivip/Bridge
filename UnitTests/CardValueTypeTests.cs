using System.Collections.Generic;
using System.Linq;
using ShowhandGame.Models;
using Xunit;

namespace UnitTests
{
    public class CardValueTypeTests
    {

        [Fact]
        public void ShouldReturnTheIntValueForCardValueTypeEnum()
        {
            const CardValueType valEnum = CardValueType.A;

            const int intVal = (int) valEnum;
            
            Assert.Equal(14, intVal);
        }

        [Fact]
        public void ShouldReturnValueOrderedSequence()
        {

            var cardValList = new List<CardValueType>
            {
                CardValueType.A,
                CardValueType.Five,
                CardValueType.T,
                CardValueType.Two,
                CardValueType.K,
            };

            var ordered = cardValList.OrderByDescending(x => (int) x).ToList();

            Assert.Equal(CardValueType.A, ordered.First());
            Assert.Equal(CardValueType.Two, ordered.Last());
        }
    }
}