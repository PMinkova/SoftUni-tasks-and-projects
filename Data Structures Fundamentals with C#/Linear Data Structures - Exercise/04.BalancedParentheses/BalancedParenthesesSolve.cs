namespace Problem04.BalancedParentheses
{
    using System.Collections.Generic;
    using System.Linq;

    public class BalancedParenthesesSolve : ISolvable
    {
        public bool AreBalanced(string parentheses)
        {
            var open = new Stack<char>();

            var openParentheses = "[({";
            var closedParentheses = "])}";

            var matchingBrackets = new Dictionary<char, char>();

            matchingBrackets['['] = ']';
            matchingBrackets['('] = ')';
            matchingBrackets['{'] = '}';

            if (parentheses.Length % 2 != 0)
            {
                return false;
            }

            foreach (var element in parentheses)
            {
                if (openParentheses.Contains(element))
                {
                    open.Push(element);
                }
                else if (closedParentheses.Contains(element))
                {
                    if (!openParentheses.Any())
                    {
                        return false;
                    }

                    if (matchingBrackets[open.Pop()] != element)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
