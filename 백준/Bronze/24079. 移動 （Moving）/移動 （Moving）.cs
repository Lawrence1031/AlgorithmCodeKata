namespace _24079
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            Console.WriteLine(x + y <= z ? 1 : 0);
        }
    }
}