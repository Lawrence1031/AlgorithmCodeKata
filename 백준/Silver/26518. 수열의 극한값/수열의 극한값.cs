namespace _26518
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            double b = numbers[0];
            double c = numbers[1];

            double r = (b + Math.Sqrt(b * b + 4 * c)) / 2.0;

            Console.WriteLine(r.ToString("F9"));
        }
    }
}