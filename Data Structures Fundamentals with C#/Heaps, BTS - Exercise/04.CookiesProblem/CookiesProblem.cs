using Wintellect.PowerCollections;

namespace _04.CookiesProblem
{
    public class CookiesProblem
    {
        public int Solve(int k, int[] cookies)
        {
            var priorityQueue = new OrderedBag<int>();

            foreach (var cookie in cookies)
            {
                priorityQueue.Add(cookie);
            }

            var currentMinSweetness = priorityQueue[0];
            var steps = 0;

            while (currentMinSweetness < k && priorityQueue.Count > 1)
            {
                var leastSweetCooke = priorityQueue.RemoveFirst();
                var secondLeastSweetCookie = priorityQueue.RemoveFirst();

                var combined = leastSweetCooke + 2 * secondLeastSweetCookie;

                priorityQueue.Add(combined);

                currentMinSweetness = priorityQueue[0];
                steps++;
            }

            return currentMinSweetness < k ? -1 : steps;
        }
    }
}
