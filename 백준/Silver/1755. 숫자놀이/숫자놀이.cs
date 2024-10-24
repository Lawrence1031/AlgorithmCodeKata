using System.Text;

namespace _1755
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int M = int.Parse(inputs[0]);
            int N = int.Parse(inputs[1]);
            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int i = M; i <= N; i++)
            {
                string numberAlp = NumToAlp(i);
                dict.Add(numberAlp, i);
            }

            int cnt = 0;
            foreach (var item in dict.OrderBy(x => x.Key))
            {
                Console.Write(item.Value + " ");
                cnt++;

                if (cnt % 10 == 0) Console.WriteLine();
            }
        }

        static string NumToAlp(int n)
        {
            StringBuilder sb = new StringBuilder();

            int ten = n / 10;
            int rest = n % 10;

            if (ten != 0)
            {
                sb.Append(MakeAlp(ten));
            }

            sb.Append(MakeAlp(rest));

            return sb.ToString();
        }

        static string MakeAlp(int n)
        {
            switch (n)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7:return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: return n.ToString();
            }
        }
    }
}