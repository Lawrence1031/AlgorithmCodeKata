using System.Text;

namespace _1158
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int K = int.Parse(inputs[1]);
            int now = 0;
            StringBuilder sb = new StringBuilder();

            List<int> round = new List<int>();

            for (int i = 1; i <= N; i++)
            {
                round.Add(i);
            }

            sb.Append("<");
            while (round.Count > 0)
            {
                now = (now + K - 1) % round.Count;
                sb.Append($"{round[now]}");
                round.RemoveAt(now);

                if (round.Count > 0)
                {
                    sb.Append(", ");
                }
            }
            sb.Append(">");

            Console.WriteLine(sb.ToString());
        }
    }
}