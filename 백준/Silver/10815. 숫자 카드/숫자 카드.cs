using System.Text;

namespace _10815
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] nArr = Console.ReadLine().Split(' ');
            HashSet<string> nSet = new HashSet<string>(nArr);

            int M = int.Parse(Console.ReadLine());
            string[] mArr = Console.ReadLine().Split(' ');
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < M; i++)
            {
                if (nSet.Contains(mArr[i]))
                {
                    sb.Append(1 + " ");
                }
                else
                {
                    sb.Append(0 + " ");
                }
            }
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}