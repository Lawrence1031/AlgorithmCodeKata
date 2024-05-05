using System.Text;

namespace _1159
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<char, int> dict = new Dictionary<char, int>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                char key = input[0];

                if (dict.ContainsKey(key))
                {
                    dict[key]++;
                }
                else
                {
                    dict.Add(key, 1);
                }
            }

            var sortedDict = dict.Where(x => x.Value >= 5).OrderBy(x => x.Key).ToList();

            foreach (var item in sortedDict)
            {
                sb.Append(item.Key);
            }

            if (sb.Length > 0)
            {
                Console.WriteLine(sb.ToString());
            }
            else
            {
                Console.WriteLine("PREDAJA");
            }
        }
    }
}