using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_StoreBoxes
{
    public class Item
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }

    class Box
    {

        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int Quantity { get; set; }

        public decimal PriceForABox { get; set; }
    }

    class StoreBoxes
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            List<Box> boxes = new List<Box>();

            while (line != "end")
            {
                string[] data = line.Split();

                string serialNumber = data[0];
                string name = data[1];
                int itemQuantity = int.Parse(data[2]);
                decimal itemPrice = decimal.Parse(data[3]);

                Box box = new Box();

                box.SerialNumber = serialNumber;
                box.Item = new Item();
                box.Item.Price = itemPrice;
                box.Item.Name = name;
                box.Quantity = itemQuantity;                
                box.PriceForABox = box.Quantity * box.Item.Price;

                boxes.Add(box);
                line = Console.ReadLine();
            }

            List<Box> sortedBoxes = boxes.OrderByDescending(p => p.PriceForABox).ToList();

            foreach (var box in sortedBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PriceForABox:f2}");
            }
        }
    }
}
