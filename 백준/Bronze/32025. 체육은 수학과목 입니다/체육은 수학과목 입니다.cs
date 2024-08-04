namespace _32025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int H = int.Parse(Console.ReadLine());
            int W = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Min(H, W) * 50);
        }
    }
}