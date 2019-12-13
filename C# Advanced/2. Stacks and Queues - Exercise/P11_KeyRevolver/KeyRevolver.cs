using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace P11_KeyRevolver
{
    class KeyRevolver
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());

            int[] bulletesArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] locksArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int intelligenceValue = int.Parse(Console.ReadLine());

            Stack<int> bullets = new Stack<int>(bulletesArray);
            Queue<int> locks = new Queue<int>(locksArray);

            int bulletsInBarrelLeft = gunBarrelSize;;

            while (true)
            {
                if (!locks.Any())
                {
                    int usedBulletsCount = bulletesArray.Length - bullets.Count;
                    int moneyEarned = intelligenceValue - usedBulletsCount * bulletPrice;
                    Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
                    break;
                }
                else if (!bullets.Any())
                { 
                    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
                    break;
                }

                int currentBullet = bullets.Pop();
                int currentLock = locks.Peek();

                if (currentBullet <= currentLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                bulletsInBarrelLeft -= 1;

                if (bulletsInBarrelLeft == 0 && bullets.Any())
                {
                    Console.WriteLine("Reloading!");
                    bulletsInBarrelLeft = gunBarrelSize;
                }
            }
        }
    }
}
