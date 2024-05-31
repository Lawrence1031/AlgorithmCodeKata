namespace _1004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int x1 = int.Parse(inputs[0]);
                int y1 = int.Parse(inputs[1]);
                int x2 = int.Parse(inputs[2]);
                int y2 = int.Parse(inputs[3]);

                int n = int.Parse(Console.ReadLine());
                int[,] planets = new int[n, 3];

                for (int j = 0; j < n; j++)
                {
                    inputs = Console.ReadLine().Split(' ');
                    planets[j, 0] = int.Parse(inputs[0]);
                    planets[j, 1] = int.Parse(inputs[1]);
                    planets[j, 2] = int.Parse(inputs[2]);
                }

                int cnt = 0;

                for (int j = 0; j < n; j++)
                {
                    int cx = planets[j, 0];
                    int cy = planets[j, 1];
                    int r = planets[j, 2];

                    bool startInside = IsInside(x1, y1, cx, cy, r);
                    bool endInside = IsInside(x2, y2, cx, cy, r);

                    if (startInside != endInside)
                    {
                        cnt++;
                    }
                }

                Console.WriteLine(cnt);
            }
        }

        static bool IsInside(int x, int y, int cx, int cy, int r)
        {
            int dx = x - cx;
            int dy = y - cy;
            return dx * dx + dy * dy < r * r;
        }
    }
}