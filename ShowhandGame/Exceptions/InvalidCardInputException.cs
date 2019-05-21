using System;

namespace ShowhandGame.Exceptions
{
    public class InvalidCardInputException : Exception
    {
        public InvalidCardInputException()
        {
        }
        
        public InvalidCardInputException(string text) : base($"Card text input is invalid {text}")
        {
        }
    }
}