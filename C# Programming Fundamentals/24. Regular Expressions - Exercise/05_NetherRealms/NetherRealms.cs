using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _05_NetherRealms
{
    class NetherRealms
    {
        static void Main(string[] args)
        {
            string healthPattern = @"[^\d+\-*\/.]";
            Regex healthRegex = new Regex(healthPattern);

            string damagePattern = @"-?[0-9]+\.?[0-9]*";
            Regex damageRegex = new Regex(damagePattern);

            string operatorPattern = @"[*\/]";
            Regex operatorRegex = new Regex(operatorPattern);

            List<string> demons = new List<string>();

           //Regex.Split().OrderdBy(x=>x).ToArray();
            string[] demonNames = Regex.Split(Console.ReadLine(), @"\s*,\s*"); // можем и още тук да сортираме, за да избегнем създаването на нов речник
            
            for (int i = 0; i < demonNames.Length; i++)
            {
                string currentDemon = demonNames[i];

                var healthSymbols = healthRegex.Matches(currentDemon);
                var currentHealth = 0;

                foreach (Match symbol in healthSymbols)
                {
                    currentHealth += char.Parse(symbol.Value);
                }

                var damageDigits = damageRegex.Matches(currentDemon);
                var currentDamage = 0d;

                foreach (Match digit in damageDigits)
                {
                    currentDamage += double.Parse(digit.Value);
                }

                var matchedOperators = operatorRegex.Matches(currentDemon);

                foreach (Match op in matchedOperators)
                {
                    if (op.Value == "*")
                    {
                        currentDamage *= 2;
                    }
                    else
                    {
                        currentDamage /= 2;
                    }
                }

                string currentResult = $"{currentDemon} - {currentHealth} health, {currentDamage:f2} damage";
                demons.Add(currentResult);
            }

            demons.Sort();
            Console.WriteLine(String.Join("\n", demons));
        }
    }
}
