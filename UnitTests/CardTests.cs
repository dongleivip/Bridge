using System;
using ShowhandGame.Exceptions;
using ShowhandGame.Models;
using Xunit;

namespace UnitTests
{
    public class CardTests
    {
        [Theory]
        [InlineData("2H", CardValueType.Two, SuitType.H)]
        [InlineData("3D", CardValueType.Three, SuitType.D)]
        [InlineData("5S", CardValueType.Five, SuitType.S)]
        [InlineData("9C", CardValueType.Nine, SuitType.C)]
        [InlineData("KD", CardValueType.K, SuitType.D)]
        public void ShouldCreateACardInstance(string input, CardValueType cardValueType, SuitType suitType)
        {
            var card = new Card(input);
            
            Assert.Equal(cardValueType, card.ValueType);
            Assert.Equal(suitType, card.Suit);
        }

        [Theory]
        [InlineData("10A")]
        [InlineData("3F")]
        [InlineData("XD")]
        public void ShouldThrowExceptionWhenInputIsInvalid(string input)
        {
            Assert.Throws<InvalidCardInputException>(() => new Card(input));
        }
    }
}