namespace _10156
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');

            int K = int.Parse(inputs[0]);
            int N = int.Parse(inputs[1]);
            int M = int.Parse(inputs[2]);

            if (M < K * N)
            {
                Console.WriteLine(K * N - M);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}