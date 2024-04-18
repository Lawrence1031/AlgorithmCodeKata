namespace _13241
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            long A = long.Parse(inputs[0]);
            long B = long.Parse(inputs[1]);

            Console.WriteLine(LCM(A, B));
        }

        static long LCM(long A, long B)
        {
            return A * B / GCD(A, B);
        }

        static long GCD(long A, long B)
        {
            return (A % B == 0 ? B : GCD(B, A % B));
        }
    }
}