namespace Telephony.Core
{
    using System.Linq;

    using Exceptions;
    using Contracts;
    using Models;
    using Models.Contracts;
    using IO.Contracts;
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private readonly IStationaryPhone stationaryPhone;
        private readonly ISmartPhone smartphone;

        private Engine()
        {
            this.stationaryPhone = new StationaryPhone();
            this.smartphone = new SmartPhone();
        }

        public Engine(IReader reader, IWriter writer) 
            : this()
        {
            this.reader = reader;
            this.writer = writer;
        }
        public void Run()
        {
            var phoneNumbers = this.reader
                .ReadLine()
                .Split(' ')
                .ToArray();

            var URLs = this.reader
                .ReadLine()
                .Split(' ')
                .ToArray();

            foreach (var phoneNumber in phoneNumbers)
            {
                try
                {
                    if (phoneNumber.Length == 10)
                    {
                        this.writer.WriteLine(this.smartphone.Call(phoneNumber));
                    }
                    else if (phoneNumber.Length == 7)
                    {
                        this.writer.WriteLine(this.stationaryPhone.Call(phoneNumber));
                    }
                    else
                    {
                        throw new InvalidPhoneNumberException();
                    }
                }
                catch (InvalidPhoneNumberException ipne)
                {
                    this.writer.WriteLine(ipne.Message);
                }
            }

            foreach (var URL in URLs)
            {
                try
                {
                    this.writer.WriteLine(this.smartphone.BrowsURL(URL));
                }
                catch (InvalidURLException iue)
                {
                    this.writer.WriteLine(iue.Message);
                }
            }
        }
    }
}