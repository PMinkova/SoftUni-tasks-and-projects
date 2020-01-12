using System;
using System.Collections.Generic;

namespace _04_MorseCodeTranslator
{
    class MorseCodeTranslator
    {
        static void Main(string[] args)
        {

            var morseCode = new Dictionary<char, string>();

            morseCode.Add('A', ".-");
            morseCode.Add('B', " -...");
            morseCode.Add('C', "-.-.");
            morseCode.Add('D', "-..");
            morseCode.Add('E', ".");
            morseCode.Add('F', "..-.");
            morseCode.Add('G', "--.");
            morseCode.Add('H', "....");
            morseCode.Add('I', "..");
            morseCode.Add('J', ".---");
            morseCode.Add('K', " -.-");
            morseCode.Add('L', ".-..");
            morseCode.Add('M', "--");
            morseCode.Add('N', "-.");
            morseCode.Add('O', "---");
            morseCode.Add('P', ".--.");
            morseCode.Add('Q', "--.-");
            morseCode.Add('R', ".-.");
            morseCode.Add('S', "...");
            morseCode.Add('T', "-");
            morseCode.Add('U', "..-");
            morseCode.Add('V', "...-");
            morseCode.Add('W', ".--");
            morseCode.Add('X', "-..-");
            morseCode.Add('Y', "-.--");
            morseCode.Add('Z', "--..");

            morseCode.Add(' ', "|");

            string[] morseCodeMessage = Console.ReadLine().Split();

            string result = String.Empty;

            for (int i = 0; i < morseCodeMessage.Length; i++)
            {
                string currentSymbol = morseCodeMessage[i];

                foreach (var kvp in morseCode)
                {
                    if (currentSymbol == kvp.Value)
                    {
                        result += kvp.Key;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
