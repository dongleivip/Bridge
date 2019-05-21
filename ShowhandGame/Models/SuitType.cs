using System.ComponentModel;

namespace ShowhandGame.Models
{
    public enum SuitType
    {
        [Description("Clubs")]
        C,
        
        [Description("Diamonds")]
        D,
        
        [Description("Hearts")]
        H, 
        
        [Description("Spades")]
        S,
    }
}