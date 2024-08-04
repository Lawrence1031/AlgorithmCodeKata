namespace _31821
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] price = new int[N];

            for (int i = 0; i < N; i++)
            {
                price[i] = int.Parse(Console.ReadLine());
            }

            int M = int.Parse(Console.ReadLine());

            int total = 0;
            for (int i = 0; i < M; i++)
            {
                int select = int.Parse(Console.ReadLine());

                total += price[select - 1];
            }

            Console.WriteLine(total);
        }
    }
}