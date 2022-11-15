namespace Telephony.Models
{
    using System.Linq;

    using Exceptions;
    using Contracts;
    public class StationaryPhone : IStationaryPhone
    {

        protected bool IsNumberValid(string phoneNumber)
        {
            if (phoneNumber.All(n => char.IsDigit(n)))
            {
                return true;
            }

            return false;
        }

        public virtual string Call(string phoneNumber)
        {
            if (!IsNumberValid(phoneNumber))
            {
                throw new InvalidPhoneNumberException();
            }

            return $"Dialing... {phoneNumber}";
        }
    }
}
