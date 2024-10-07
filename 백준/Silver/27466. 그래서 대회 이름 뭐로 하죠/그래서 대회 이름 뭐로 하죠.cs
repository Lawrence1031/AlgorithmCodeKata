using Microsoft.VisualBasic;
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

            HashSet<char> consonants = new HashSet<char>("BCDFGHJKLMNPQRSTVWXYZ");

            StringBuilder sb = new StringBuilder();

            for (int i = N - 1; i >= 0; i--)
            {
                if (sb.Length == 0 && (consonants.Contains(S[i])))
                {
                    sb.Append(S[i]);
                }
                else if ((sb.Length == 1 || sb.Length == 2) && S[i] == 'A')
                {
                    sb.Append(S[i]);
                }
                else if (sb.Length > 2)
                {
                    sb.Append(S[i]);
                }

                if (sb.Length == M)
                {
                    break;
                }
            }

            if (sb.Length != M)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
                string answer = sb.ToString();
                char[] charArr = answer.ToCharArray();
                Array.Reverse(charArr);
                answer = new string(charArr);
                Console.WriteLine(answer);
            }
        }
    }
}