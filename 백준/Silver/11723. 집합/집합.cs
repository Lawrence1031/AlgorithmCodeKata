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
            List<int> S = new List<int>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < M; i++)
            {
                input = Console.ReadLine();
                string[] arr = input.Split(' ');
                string cmd = arr[0];

                if (cmd == "add")
                {
                    int num = int.Parse(arr[1]);
                    if (!S.Contains(num))
                    {
                        S.Add(num);
                    }
                }
                else if (cmd == "remove")
                {
                    int num = int.Parse(arr[1]);
                    if (S.Contains(num))
                    {
                        S.Remove(num);
                    }
                }
                else if (cmd == "check")
                {
                    int num = int.Parse(arr[1]);
                    if (S.Contains(num))
                    {
                        sb.AppendLine("1");
                    }
                    else
                    {
                        sb.AppendLine("0");
                    }
                }
                else if (cmd == "toggle")
                {
                    int num = int.Parse(arr[1]);
                    if (S.Contains(num))
                    {
                        S.Remove(num);
                    }
                    else
                    {
                        S.Add(num);
                    }
                }
                else if (cmd == "all")
                {
                    S = new List<int>(20) { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
                }
                else
                {
                    S.Clear();
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}