namespace Telephony.Models
{
    using System.Linq;

    using Exceptions;
    using Contracts;
    public class SmartPhone : ISmartPhone
    {
        public string Call(string phoneNumber)
        {
            if (!IsNumberValid(phoneNumber))
            {
                throw new InvalidPhoneNumberException();
            }

            return $"Calling... {phoneNumber}";
        }

        public string BrowsURL(string URL)
        {
            if (!IsURLValid(URL))
            {
                throw new InvalidURLException();
            }

            return $"Browsing: {URL}!";
        }

        private bool IsNumberValid(string phoneNumber)
        {
            if (phoneNumber.All(char.IsDigit))
            {
                return true;
            }

            return false;
        }

        private bool IsURLValid(string URL)
        {
            if (URL.All(symbol => !char.IsDigit(symbol)))
            {
                return true;
            }

            return false;
        }
    }
}