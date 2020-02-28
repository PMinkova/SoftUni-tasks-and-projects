using System;
class GreaterOfTwoValues
{
    static int GetMax(int firstNumber, int secondNumber)
    {
        int maxNumber = 0;

        if (firstNumber > secondNumber)
        {
            maxNumber = firstNumber;
        }
        else
        {
            maxNumber = secondNumber;
        }

        return maxNumber;
    }

    static char GetMax(char firstChar, char secondChar)
    {
        char maxChar = 'a';

        if (firstChar > secondChar)
        {
            maxChar = firstChar;
        }
        else
        {
            maxChar = secondChar;
        }

        return maxChar;
    }

    static string GetMax(string firstText, string secondText)
    {
        string maxString = "";

        if (firstText.CompareTo(secondText) > 0)
        {
            maxString = firstText;
        }
        else
        {
            maxString = secondText;
        }

        return maxString;
    }

    static void Main()
    {
        string type = Console.ReadLine();

        if (type == "int")
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int result = GetMax(firstNumber, secondNumber);
            Console.WriteLine(result);
        }
        else if (type == "char")
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            char result = GetMax(firstChar, secondChar);
            Console.WriteLine(result);
        }
        else if (type == "string")
        {
            string firstText = Console.ReadLine();
            string secondText = Console.ReadLine();

            string result = GetMax(firstText, secondText);
            Console.WriteLine(result);
        }
    }
}

