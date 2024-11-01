namespace _25591
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = inputs[0];
            int m = inputs[1];

            int a, b, c, d, q, r;

            a = 100 - n;
            b = 100 - m;
            c = 100 - (a + b);
            d = a * b;
            q = d / 100;
            r = d % 100;
            
            Console.WriteLine($"{a} {b} {c} {d} {q} {r}");
            Console.WriteLine($"{c + q} {r}");
        }
    }
}