namespace _29736
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);

            inputs = Console.ReadLine().Split(' ');
            int K = int.Parse(inputs[0]);
            int X = int.Parse(inputs[1]);

            int cnt = 0;

            for (int i = A; i <= B; i++)
            {
                if (Math.Abs(K - i) <= X)
                {
                    cnt++;
                }
            }

            Console.WriteLine(cnt == 0 ? "IMPOSSIBLE" : cnt);
        }
    }
}