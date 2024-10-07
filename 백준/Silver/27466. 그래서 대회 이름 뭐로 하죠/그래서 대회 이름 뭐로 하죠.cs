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
            List<int> AIdx = new List<int>();

            for (int i = 0; i < N; i++)
            {
                if (S[i] == 'A')
                {
                    AIdx.Add(i);
                }
            }
            
            if (AIdx.Count < 2)
            {
                Console.WriteLine("NO");
                return;
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < AIdx[AIdx.Count - 2]; i++)
            {
                sb.Append(S[i]);

                if (sb.Length == M - 3)
                {
                    break;
                }
            }

            sb.Append("AA");

            for (int i = AIdx[AIdx.Count - 1]; i < N; i++)
            {
                if (consonants.Contains(S[i]))
                {
                    sb.Append(S[i]);
                    break;
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