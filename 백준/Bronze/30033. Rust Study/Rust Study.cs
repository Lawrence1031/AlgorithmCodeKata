namespace _30033
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] plans = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] actuals = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int cnt = 0;

            for (int i = 0; i < N; i++)
            {
                if (plans[i] <= actuals[i]) cnt++;
            }

            Console.WriteLine(cnt);
        }
    }
}