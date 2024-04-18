namespace _1934
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int A = int.Parse(inputs[0]);
                int B = int.Parse(inputs[1]);

                Console.WriteLine(LCM(A, B));
            }
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