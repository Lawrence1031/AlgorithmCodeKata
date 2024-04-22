namespace _24417
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] f = new int[N + 1];
            f[1] = 1;
            f[2] = 1;

            for (int i = 3; i <= N; i++)
            {
                f[i] = (f[i - 1] + f[i - 2]) % 1000000007;
            }
            Console.Write(f[N]);
            Console.WriteLine(" " + (N - 2));
        }
    }
}