namespace _2097
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int min = int.MaxValue;

            if (N == 1 || N == 2)
            {
                Console.WriteLine(4);
                return;
            }

            for (int w = 1; w * w <= N; w++)
            {
                int l = (N + w - 1) / w;
                int round = 2 * (w + l - 2);
                if (round < min)
                {
                    min = round;
                }
            }

            if ((int)Math.Sqrt(N) * (int)Math.Sqrt(N) != N)
            {
                for (int w = 1; w <= Math.Sqrt(N); w++)
                {
                    int l = (N + w - 1) / w;
                    int perimeter = 2 * (w + l - 2);
                    if (perimeter < min)
                    {
                        min = perimeter;
                    }
                }
            }

            Console.WriteLine(min);
        }
    }
}