using System;

namespace CustomRandomList
{
    public class StartUp
    {
        public static void Main()
        {
            RandomList randomList = new RandomList();
           
            randomList.Add("1");
            randomList.Add("2");
            randomList.Add("3");

            var result = randomList.RemoveRandomElement();
            Console.WriteLine(result);
        }
    }
}
