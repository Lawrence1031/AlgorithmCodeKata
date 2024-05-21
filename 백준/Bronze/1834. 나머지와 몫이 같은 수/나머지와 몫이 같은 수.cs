namespace _1834
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            long sum = ((long)N + 1) * (N - 1) * N / 2;

            Console.WriteLine(sum);
        }
    }
}