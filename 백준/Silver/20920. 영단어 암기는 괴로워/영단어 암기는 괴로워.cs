using System.Text;

namespace _20920
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 자주 나오는 단어일수록 앞에 배치
            // 해당 단어의 길이가 길수록 앞에 배치
            // 알파벳 사전 순으로 앞에 있는 단어일수록 앞에 배치
            // 길이가 M보다 짧은 길이의 단어는 제외

            string input = Console.ReadLine();
            int N = int.Parse(input.Split(' ')[0]);
            int M = int.Parse(input.Split(' ')[1]);
            Dictionary<string, int> dict = new Dictionary<string, int>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                input = Console.ReadLine();

                if (input.Length >= M)
                {
                    if (dict.ContainsKey(input))
                    {
                        dict[input]++;
                    }
                    else
                    {
                        dict.Add(input, 1);
                    }
                }
            }

            var sortedDict = dict.OrderByDescending(x => x.Value)
                                 .ThenByDescending(x => x.Key.Length)
                                 .ThenBy(x => x.Key);            

            foreach (var item in sortedDict)
            {
                sb.AppendLine(item.Key);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}