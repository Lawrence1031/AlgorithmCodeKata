using System;
using System.Security.Cryptography;
using System.Text;

namespace _11723
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int M = int.Parse(input);
            HashSet<int> S = new HashSet<int>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < M; i++)
            {
                input = Console.ReadLine();
                string[] arr = input.Split(' ');
                string cmd = arr[0];
                int num = 0;

                if (arr.Length > 1)
                {
                    num = int.Parse(arr[1]);
                }

                switch (cmd)
                {
                    case "add":
                        S.Add(num);
                        break;
                    case "remove":
                        S.Remove(num);
                        break;
                    case "check":
                        sb.AppendLine(S.Contains(num) ? "1" : "0");
                        break;
                    case "toggle":
                        if (!S.Add(num))
                        {
                            S.Remove(num);
                        }
                        break;
                    case "all":
                        S.Clear();
                        for (int j = 1; j <= 20; j++)
                        {
                            S.Add(j);
                        }
                        break;
                    case "empty":
                        S.Clear();
                        break;
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}