namespace _9501
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int test = 0; test < T; test++)
            {
                int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int N = inputs[0];
                int D = inputs[1];
                int count = 0;

                for (int i = 0; i < N; i++)
                {
                    int[] spaceShip = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                    int v = spaceShip[0];
                    int f = spaceShip[1];
                    int c = spaceShip[2];

                    double possible = (double)v * f / c;

                    if (possible >= D) count++;
                }

                Console.WriteLine(count);
            }
        }
    }
}