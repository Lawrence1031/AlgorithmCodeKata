namespace _1952
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int M = int.Parse(inputs[0]);
            int N = int.Parse(inputs[1]);

            int cnt = 2 * (Math.Min(M, N) - 1);
            if (M > N)
            {
                cnt++;
            }

            Console.WriteLine(cnt);
        }
    }
}