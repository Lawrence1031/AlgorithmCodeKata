namespace _20492
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());

            Console.WriteLine($"{N * 0.78} {N - (N * 0.2 * 0.22)}");
        }
    }
}