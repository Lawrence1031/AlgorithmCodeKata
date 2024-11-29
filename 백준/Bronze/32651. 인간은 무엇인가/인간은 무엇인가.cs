namespace _326513
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(n > 100000 ? "No" : n % 2024 == 0 ? "Yes" : "No");
        }
    }
}