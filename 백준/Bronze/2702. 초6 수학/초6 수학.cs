namespace _2702
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);

                int gcd = GCD(a, b);
                int lcm = LCM(a, b);

                Console.WriteLine($"{lcm} {gcd}");
            }
        }

        static int GCD(int a, int b)
        {
            return (a % b == 0 ? b : GCD(b, a % b));
        }

        static int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }
    }
}