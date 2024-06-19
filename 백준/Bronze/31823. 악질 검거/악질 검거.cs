using System.Text;

namespace _31823
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);
            StringBuilder sb = new StringBuilder();
            HashSet<int> reverseCnt = new HashSet<int>();

            for (int i = 0; i < N; i++)
            {
                string[] reverseStrig = Console.ReadLine().Split(' ').ToArray();
                int maxCnt = 0;
                int nowCnt = 0;
                for (int j = 0; j < reverseStrig.Length - 1; j++)
                {
                    if (reverseStrig[j] == ".")
                    {
                        nowCnt++;
                    }
                    else
                    {
                        nowCnt = 0;
                    }

                    if (nowCnt > maxCnt)
                    {
                        maxCnt = nowCnt;
                    }
                }

                reverseCnt.Add(maxCnt);
                sb.AppendLine($"{maxCnt} {reverseStrig[M]}");
            }

            Console.WriteLine(reverseCnt.Count);
            Console.WriteLine(sb);
        }
    }
}