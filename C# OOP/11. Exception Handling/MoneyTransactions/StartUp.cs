namespace MoneyTransactions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main(string[] args)
        {
            var bankAccounts = new Dictionary<int, double>();

            var inputArguments = Console.ReadLine()
                .Split(",")
                .ToArray();

            AddBankAccounts(inputArguments, bankAccounts);

            var input = Console.ReadLine();

            while (input != "End")
            {
                var commandArguments = input.Split(" ");
                var command = commandArguments[0];

                try
                {

                    var accountNumber = int.Parse(commandArguments[1]);

                    if (!bankAccounts.ContainsKey(accountNumber))
                    {
                        throw new InvalidAccountException();
                    }

                    var sum = double.Parse(commandArguments[2]);

                    if (command == "Deposit")
                    {
                        bankAccounts[accountNumber] += sum;
                        Console.WriteLine($"Account {accountNumber} has new balance: {bankAccounts[accountNumber]:F2}");
                    }
                    else if (command == "Withdraw")
                    {
                        if (bankAccounts[accountNumber] < sum)
                        {
                            throw new InsufficientBalanceException();
                        }

                        bankAccounts[accountNumber] -= sum;

                        Console.WriteLine($"Account {accountNumber} has new balance: {bankAccounts[accountNumber]:F2}");
                    }
                    else
                    {
                        throw new InvalidCommandException();
                    }
                }
                catch (InvalidAccountException iae)
                {
                    Console.WriteLine(iae.Message);
                }
                catch (InsufficientBalanceException ibe)
                {
                    Console.WriteLine(ibe.Message);
                }
                catch (InvalidCommandException ice)
                {
                    Console.WriteLine(ice.Message);
                }
                finally
                {
                    Console.WriteLine("Enter another command");
                }

                input = Console.ReadLine();
            }
        }

        private static void AddBankAccounts(string[] inputArguments, Dictionary<int, double> bankAccounts)
        {
            for (int i = 0; i < inputArguments.Length; i++)
            {
                var accountArguments = inputArguments[i]
                    .Split('-');

                var accountNumber = int.Parse(accountArguments[0]);
                var accountBalance = double.Parse(accountArguments[1]);

                bankAccounts.Add(accountNumber, accountBalance);
            }
        }

        public class InvalidAccountException : ApplicationException
        {
            private const string DefaultMessage = "Invalid account!";

            public InvalidAccountException()
                : base(DefaultMessage)
            {

            }
        }

        public class InvalidCommandException : ApplicationException
        {
            private const string DefaultMessage = "Invalid command!";

            public InvalidCommandException()
                : base(DefaultMessage)
            {

            }
        }

        public class InsufficientBalanceException : ApplicationException
        {
            private const string DefaultMessage = "Insufficient balance!";

            public InsufficientBalanceException()
                : base(DefaultMessage)
            {

            }
        }
    }
}
