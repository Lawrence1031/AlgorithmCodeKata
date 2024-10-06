namespace _2217
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] ropes = new int[N];
            for (int i = 0; i < N; i++)
            {
                ropes[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(ropes);
            int maxWeight = 0;

            for (int i = 0; i < N; i++)
            {
                int nowWeight = ropes[i] * (N - i);

                maxWeight = Math.Max(maxWeight, nowWeight);
            }

            Console.WriteLine(maxWeight);
        }
    }
}