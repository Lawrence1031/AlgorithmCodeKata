namespace _27890
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int x0 = inputs[0];
            int N  = inputs[1];
            int now = x0;

            for (int i = 0; i < N; i++)
            {
                if (x0 % 2 == 0)
                {
                    now = (x0 / 2) ^ 6;
                }
                else
                {
                    now = (x0 * 2) ^ 6;
                }

                x0 = now;
            }

            Console.WriteLine(now);
        }
    }
}