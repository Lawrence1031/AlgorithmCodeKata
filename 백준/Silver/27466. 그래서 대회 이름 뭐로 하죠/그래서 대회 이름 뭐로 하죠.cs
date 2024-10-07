using System.Text;

namespace _27466
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);
            string S = Console.ReadLine();

            char[] consonants = "BCDFGHJKLMNPQRSTVWXYZ".ToArray();

            StringBuilder sb = new StringBuilder();

            for (int i = N - 1; i >= 0; i--)
            {
                if (Array.Exists(consonants, c => c == S[i]) && sb.Length == 0)
                {
                    sb.Insert(0, S[i]);
                }
                else if (sb.Length > 0 && sb.Length < 3 && S[i] == 'A')
                {
                    sb.Insert(0, 'A');
                }
                else if (sb.Length >= 3 && sb.Length < M)
                {
                    sb.Insert(0, S[i]);
                }
            }

            if (sb.Length == M)
            {
                Console.WriteLine("YES");
                Console.WriteLine(sb.ToString());
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}