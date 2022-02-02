using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Easter_Bonuses
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = null;
            List<decimal> personsBonuses = new List<decimal>();
            while ((command = Console.ReadLine()) != "stop")
            {
                List<decimal> tasks = Console.ReadLine().Split().Select(x => decimal.Parse(x[0].ToString())).ToList();
                List<decimal> currentList = tasks.ToArray().ToList();
                for (int i = 0; i < tasks.Count; i++)
                {
                    decimal num = 1;
                    for (int a = 0; a < currentList.Count; a++)
                    {
                        if (i == a)
                        {
                            continue;
                        }
                        num *= currentList[a];
                    }
                    tasks[i] = num;
                }
                decimal personBonus = tasks.Sum();
                personsBonuses.Add(personBonus);
                Console.WriteLine($"{command} has a bonus of {personBonus} lv.");
            }
            Console.WriteLine($"The amount of all bonuses is {personsBonuses.Sum()} lv.");
        }
    }
}
