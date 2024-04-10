namespace _11399
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int N = int.Parse(input);
            int[] times = new int[N];
            input = Console.ReadLine();

            for (int i = 0; i < N; i++)
            {
                times[i] = int.Parse(input.Split(' ')[i]);
            }

            Array.Sort(times);

            for (int i = times.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    times[i] += times[j];
                }
            }

            int time = times.Sum();

            Console.WriteLine(time);
        }
    }
}