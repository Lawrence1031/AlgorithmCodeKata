using System.Drawing;

namespace _1485
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                List<Point> pos = new List<Point>();
                for (int j = 0; j < 4; j++)
                {
                    string[] inputs = Console.ReadLine().Split(' ');
                    int x = int.Parse(inputs[0]);
                    int y = int.Parse(inputs[1]);
                    pos.Add(new Point(x, y));
                }

                if (IsSquare(pos))
                {
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }

        static bool IsSquare(List<Point> pos)
        {
            List<double> distances = new List<double>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 4; j++)
                {
                    distances.Add(GetDistance(pos[i], pos[j]));
                }
            }

            distances.Sort();

            return distances[0] > 0 &&
                   distances[0] == distances[1] &&
                   distances[1] == distances[2] &&
                   distances[2] == distances[3] &&
                   distances[4] == distances[5];
        }

        static double GetDistance(Point p1, Point p2)
        {
            return Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2);
        }
    }

    class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}