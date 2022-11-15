namespace Telephony.Models.Contracts
{
    internal interface ISmartPhone : IStationaryPhone
    {
        string BrowsURL(string URL);
    }
}
