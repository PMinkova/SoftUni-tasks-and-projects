using System;
using System.Text;

namespace _04_CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] textAsACharArray = text.ToCharArray();

            StringBuilder encryptedMessage = new StringBuilder();

            for (int i = 0; i < textAsACharArray.Length; i++)
            {
                encryptedMessage.Append((char)(textAsACharArray[i] + 3));
            }
            
            Console.WriteLine(encryptedMessage);
        }
    }
}
