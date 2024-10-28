namespace _3276
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int row = 1;
            int col = N;
            int sum = 201;

            for (int i = 1; i <= N; i++)
            {
                int y = i;
                int x = (int)Math.Ceiling((double)N / y);

                if (x + y < sum && x * y >= N)
                {
                    sum = x + y;
                    row = y;
                    col = x;
                }
            }

            Console.WriteLine($"{row} {col}");
        }
    }
}