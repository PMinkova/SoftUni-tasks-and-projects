using System;
using System.IO;

namespace P01_OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader(@"Input.txt");

            using (reader)
            {
                int counter = 0;

                string line = reader.ReadLine();

                using (var writer = new StreamWriter(@"Output.txt"))
                {
                    while (line != null)
                    {
                        if (counter % 2 != 0)
                        {
                            writer.WriteLine(line);
                        }

                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
