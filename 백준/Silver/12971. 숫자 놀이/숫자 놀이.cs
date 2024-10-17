namespace _12971
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int P1 = numbers[0];
            int P2 = numbers[1];
            int P3 = numbers[2];
            int X1 = numbers[3];
            int X2 = numbers[4];
            int X3 = numbers[5];

            int N = X1;
            int step = P1;

            // N % P1 = X1, N % P2 = X2, N % P3 = X3

            while (N < 1000000000)
            {
                if (N % P2 == X2 && N % P3 == X3)
                {
                    Console.WriteLine(N);
                    return;
                }

                N += step;
            }

            Console.WriteLine(-1);
        }
    }
}