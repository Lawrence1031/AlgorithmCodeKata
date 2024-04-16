using System.Text;

namespace _9506
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                StringBuilder sb = new StringBuilder();

                if (n == -1)
                {
                    break;
                }

                int[] arr = new int[n];
                int cnt = 0;
                sb.Append(n + " = ");

                for (int i = 0; i <= n / 2; i++)
                {
                    arr[i] = n % (i + 1);
                    if (arr[i] == 0)
                    {
                        cnt += i + 1;
                        sb.Append((i + 1) + " + ");
                    }
                }

                if (cnt == n)
                {
                    sb.Remove(sb.Length - 3, 2);
                    Console.WriteLine(sb.ToString());
                }
                else
                {
                    Console.WriteLine(n + " is NOT perfect.");
                }
                sb.Clear();
            }
        }
    }
}