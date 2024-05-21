namespace _1894
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != null)
            {
                string[] parts = input.Split(' ');
                double x1 = double.Parse(parts[0]);
                double y1 = double.Parse(parts[1]);
                double x2 = double.Parse(parts[2]);
                double y2 = double.Parse(parts[3]);
                double x3 = double.Parse(parts[4]);
                double y3 = double.Parse(parts[5]);
                double x4 = double.Parse(parts[6]);
                double y4 = double.Parse(parts[7]);

                double x5, y5;

                if (IsSamePoint(x1, y1, x3, y3))
                {
                    x5 = x2 + x4 - x1;
                    y5 = y2 + y4 - y1;
                }
                else if (IsSamePoint(x1, y1, x4, y4))
                {
                    x5 = x2 + x3 - x1;
                    y5 = y2 + y3 - y1;
                }
                else if (IsSamePoint(x2, y2, x3, y3))
                {
                    x5 = x1 + x4 - x2;
                    y5 = y1 + y4 - y2;
                }
                else
                {
                    x5 = x1 + x3 - x2;
                    y5 = y1 + y3 - y2;
                }

                Console.WriteLine($"{x5:F3} {y5:F3}");
            }
        }

        static bool IsSamePoint(double x1, double y1, double x2, double y2)
        {
            return x1 == x2 && y1 == y2;
        }
    }
}