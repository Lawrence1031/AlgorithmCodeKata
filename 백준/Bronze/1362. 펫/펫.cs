using System;

namespace _1362
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;

            while (true)
            {
                string[] inputs = Console.ReadLine().Split(' ');

                if (inputs[0] == "0" && inputs[1] == "0")
                {
                    return;
                }

                int o = int.Parse(inputs[0]);
                int w = int.Parse(inputs[1]);
                bool isDead = false;

                while (true)
                {
                    inputs = Console.ReadLine().Split(' ');
                    string action = inputs[0];

                    if (action == "#")
                    {
                        break;
                    }

                    int amount = int.Parse(inputs[1]);

                    if (action == "E")
                    {
                        w -= amount;
                    }
                    else if (action == "F")
                    {
                        w += amount;
                    }
                    
                    if (w <= 0)
                    {
                        isDead = true;
                    }
                }

                cnt++;
                string condition;

                if (isDead)
                {
                    condition = "RIP";
                }
                else if (w > o / 2 && w < 2 * o)
                {
                    condition = ":-)";
                }
                else
                {
                    condition = ":-(";
                }

                Console.WriteLine($"{cnt} {condition}");
            }
        }
    }
}