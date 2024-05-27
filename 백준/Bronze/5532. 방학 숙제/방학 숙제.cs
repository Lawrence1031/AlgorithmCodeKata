namespace _5532
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());
            double D = double.Parse(Console.ReadLine());

            double korean = Math.Ceiling(A / C);
            double english = Math.Ceiling(B / D);

            Console.WriteLine(L - Math.Max(korean, english));
        }
    }
}