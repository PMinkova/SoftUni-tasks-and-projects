using System;

namespace _04_PasswordValidator
{
    class PasswordValidator
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            ValidatePassword(password);
        }

        static void ValidatePassword(string password)
        {
            bool lengthIsValid = ValidatePasswordLength(password);
            bool hasLettersAndDigitsOnly = CheckTheConsistanceOfLetterAndDigits(password);
            bool hasAtLeastTwoDigits = ChechThePresenceOfAtLeastTwoDigits(password);

            if (lengthIsValid && hasLettersAndDigitsOnly && hasAtLeastTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }

            if (!lengthIsValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!hasLettersAndDigitsOnly)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!hasAtLeastTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }

        static bool ValidatePasswordLength(string password)
        {
            if (6 <= password.Length && password.Length <= 10 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool CheckTheConsistanceOfLetterAndDigits(string password)
        {
            bool isValid = true;

            for (int i = 0; i < password.Length; i++)
            {
                if (!(48 <= password[i] && password[i] <= 57 || 
                    65 <= password[i] && password[i] <= 90 || 
                    97 <= password[i] && password[i] <= 122))
                {
                    isValid = false;
                    break;
                }
            }

            if (isValid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool ChechThePresenceOfAtLeastTwoDigits(string password)
        {
            int digitsCount = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (48 <= password[i] && password[i] <= 57)
                {
                    digitsCount++;
                }
            }

            if (digitsCount >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
