using System.Text;

namespace _16972
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            HashSet<(int, int)> points = new HashSet<(int, int)> ();
            int n = 814;
            int maxCoordinate = 8140;

            while (points.Count < n)
            {
                int x = random.Next(-maxCoordinate, maxCoordinate);
                int y = random.Next(-maxCoordinate, maxCoordinate);

                if (!points.Contains((x, y)))
                {
                    points.Add((x, y));
                }
            }

            foreach (var point in points)
            {
                sb.AppendLine($"{point.Item1} {point.Item2}");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}