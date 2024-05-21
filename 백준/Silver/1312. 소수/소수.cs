namespace _1312
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');

            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);
            int N = int.Parse(inputs[2]);

            int remainder = A % B;

            for (int i = 0; i < N; i++)
            {
                remainder *= 10;
                int digit = remainder / B;
                remainder %= B;

                if (i == N - 1)
                {
                    Console.WriteLine(digit);
                    return;
                }
            }
        }
    }
}