namespace _1773
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int C = int.Parse(inputs[1]);
            bool[] fireworks = new bool[C + 1];
            int cnt = 0;

            for (int i = 0; i < N; i++)
            {
                int period = int.Parse(Console.ReadLine());

                for (int j = period; j <= C; j += period)
                {
                    if (!fireworks[j])
                    {
                        fireworks[j] = true;
                        cnt++;
                    }
                }
            }

            Console.WriteLine(cnt);
        }
    }
}