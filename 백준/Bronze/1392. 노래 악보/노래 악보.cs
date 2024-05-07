using System.Text;

namespace _1392
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int Q = int.Parse(inputs[1]);
            StringBuilder sb = new StringBuilder();

            int[] duration = new int[N];
            int[] spendTime = new int[N];

            for (int i = 0; i < N; i++)
            {
                duration[i] = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    spendTime[i] = duration[i];
                }
                else
                {
                    spendTime[i] = spendTime[i - 1] + duration[i];
                }
            }

            for (int i = 0; i < Q; i++)
            {
                int time = int.Parse(Console.ReadLine()) % spendTime.Sum();
                int answer = FindNowMusic(spendTime, time);

                sb.AppendLine(answer.ToString());
            }

            Console.WriteLine(sb.ToString());
        }

        static int FindNowMusic(int[] spendTime, int time)
        {
            for (int i = 0; i < spendTime.Length; i++)
            {
                if (time < spendTime[i])
                    return i + 1;
            }
            return -1;
        }
    }
}