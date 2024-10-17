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

            // N % P1 = X1, N % P2 = X2, N % P3 = X3

            for (int i = 1; i < 1000000000; i++)
            {
                if (i % P1 == X1 &&  i % P2 == X2 && i % P3 == X3)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine(-1);
        }
    }
}