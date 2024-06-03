namespace _3595
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // a * b * c = n;
            // 2 * (a * b + b * c + c * a)가 최소

            int minSurface = int.MaxValue;
            Tuple<int, int, int> abc = null;

            for (int a = 1; a <= Math.Ceiling(Math.Pow(n, 1.0 / 3)); a++)
            {
                if (n % a == 0)
                {
                    for (int b = a; b <= Math.Ceiling(Math.Sqrt(n / a)); b++)
                    {
                        if ((n / a) % b == 0)
                        {
                            int c = n / (a * b);
                            int surface = 2 * (a * b + b * c + c * a);
                            if (surface < minSurface)
                            {
                                minSurface = surface;
                                abc = Tuple.Create(a, b, c);
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"{abc.Item1} {abc.Item2} {abc.Item3}");
        }
    }
}