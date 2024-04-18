namespace _1735
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);

            inputs = Console.ReadLine().Split(' ');
            int C = int.Parse(inputs[0]);
            int D = int.Parse(inputs[1]);

            int lower = LCM(B, D);
            int upper = A * (lower / B) + C * (lower / D);

            while (GCD(upper, lower) != 1)
            {

                int gcd = GCD(upper, lower);
                upper /= gcd;
                lower /= gcd;
            }

            Console.WriteLine(upper + " " + lower);
        }

        static int LCM(int A, int B)
        {
            return A * B / GCD(A, B);
        }

        static int GCD(int A, int B)
        {
            return (A % B == 0 ? B : GCD(B, A % B));
        }
    }
}