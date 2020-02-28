using System;

namespace _03_ExtractFile
{
    class ExtractFile
    {
        static void Main(string[] args)
        {
            string directory = Console.ReadLine();

            int indexOfDot = directory.IndexOf('.');
            string extension = directory.Substring(indexOfDot + 1);
            int extensionLength = extension.Length;

            int lastIndexOfSlash = directory.LastIndexOf('\\');
            int fileNameLenth = directory.Length - extensionLength - lastIndexOfSlash - 2;
            string fileName = directory.Substring(lastIndexOfSlash + 1, fileNameLenth);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
