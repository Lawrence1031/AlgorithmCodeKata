namespace _30143
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int test = 0; test < t; test++)
            {
                int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int N = inputs[0];
                int A = inputs[1];
                int D = inputs[2];

                int total = D * N * (N - 1) / 2 + A * N;

                if (N == 1)
                {
                    Console.WriteLine(A);
                }
                else
                {
                    Console.WriteLine(total);
                }
            }
        }
    }
}