namespace _3004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int width = N / 2;
            int height = N - width;
            Console.WriteLine((width + 1) * (height + 1));
        }
    }
}