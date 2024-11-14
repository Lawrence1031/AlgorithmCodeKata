namespace _24087
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int S = int.Parse(Console.ReadLine());
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            int floor = Math.Max(0, (S - A + B - 1) / B);
            Console.WriteLine(250 + floor * 100);
        }
    }
}