using System.Text;

namespace _11650
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<(int, int)> list = new List<(int, int)> ();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                list.Add((int.Parse(s[0]), int.Parse(s[1])));
            }

            var sortedList = list.OrderBy(set => set.Item1)
                                 .ThenBy(set => set.Item2)
                                 .ToList();

            foreach (var item in sortedList)
            {
                sb.AppendLine($"{item.Item1} {item.Item2}");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}