namespace BookingApp.Core
{
    using System;
    using System.Text;

    using Contracts;
    using IO;
    using IO.Contracts;

    public class Engine : IEngine
    {
        private IWriter writer;
        private IReader reader;
        private IController controller;

        public Engine()
        {
            this.writer = new Writer();
            this.reader = new Reader();
            this.controller = new Controller();
        }

        public void Run()
        {
            while (true)
            {
                var input = reader.ReadLine().Split();

                if (input[0] == "Exit")
                {
                    Environment.Exit(0);
                }
                try
                {
                    var result = string.Empty;

                    if (input[0] == "AddHotel")
                    {
                        var sb = new StringBuilder();

                        var category = int.Parse(input[input.Length - 1]);

                        for (int i = 1; i < input.Length - 1; i++)
                        {
                            sb.Append(input[i] + ' ');
                        }

                        var hotelName = sb.ToString().TrimEnd();
                        result = controller.AddHotel(hotelName, category);
                    }
                    else if (input[0] == "UploadRoomTypes")
                    {
                        var hotelName = new StringBuilder();

                        int indexOfType = input.Length - 1;
                        string roomType = input[indexOfType];

                        for (int i = 1; i < indexOfType; i++)
                        {
                            hotelName.Append(input[i] + ' ');
                        }

                        result = controller.UploadRoomTypes(hotelName.ToString().TrimEnd(), roomType);
                    }
                    else if (input[0] == "SetRoomPrices")
                    {
                        var hotelName = new StringBuilder();

                        string roomType = input[^2];
                        double price = double.Parse(input[^1]);

                        for (int i = 1; i < input.Length - 2; i++)
                        {
                            hotelName.Append(input[i] + ' ');
                        }

                        result = controller.SetRoomPrices(hotelName.ToString().TrimEnd(), roomType, price);
                    }
                    else if (input[0] == "BookAvailableRoom")
                    {
                        var adults = int.Parse(input[1]);
                        var children = int.Parse(input[2]);
                        var duration = int.Parse(input[3]);
                        var category = int.Parse(input[4]);

                        result = controller.BookAvailableRoom(adults, children, duration, category);
                    }
                    else if (input[0] == "HotelReport")
                    {
                        var hotelName = new StringBuilder();

                        for (int i = 1; i < input.Length; i++)
                        {
                            hotelName.Append(input[i] + ' ');
                        }

                        result = controller.HotelReport(hotelName.ToString().TrimEnd());
                    }

                    writer.WriteLine(result);
                }
                catch (Exception ex)
                {
                    writer.WriteLine(ex.Message);
                }
            }
        }
    }
}
