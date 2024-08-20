namespace _31831
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] numA = Console.ReadLine().Split(' ');
            string[] numB = Console.ReadLine().Split(' ');
            string a = string.Concat(numA);
            string b = string.Concat(numB);

            long X = long.Parse(a);
            long Y = long.Parse(b);

            Console.WriteLine(Math.Min(X, Y));
        }
    }
}