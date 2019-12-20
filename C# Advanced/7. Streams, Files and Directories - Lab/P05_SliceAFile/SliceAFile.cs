using System;
using System.IO;

namespace P05_SliceAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;

            var totalSize = new FileInfo("sliceMe.txt").Length;
            var sizePerFile = (int) Math.Ceiling(totalSize / 4.0);

            using (FileStream r = new FileStream("sliceMe.txt",FileMode.Open))
            {
                for (int i = 1; i <= n; i++)
                {
                    var buffer = new byte[sizePerFile];
                    var readBytes = r.Read(buffer, 0, sizePerFile);

                    using (FileStream w = new FileStream($"file-{i}.txt", FileMode.OpenOrCreate))
                    {
                        w.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}
