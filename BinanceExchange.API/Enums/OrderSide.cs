using System.Runtime.Serialization;

namespace BinanceExchange.API.Enums
{
    public enum OrderSide
    {
        Unknown = 0,

        [EnumMember(Value = "BUY")]
        Buy,

        [EnumMember(Value = "SELL")]
        Sell,
    }
}