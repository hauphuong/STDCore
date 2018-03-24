using STDShop.Data.Enums;

namespace STDShop.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { get; set; }
    }
}