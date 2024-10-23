namespace _32357
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] inputs = new string[N];
            int cnt = 0;

            for (int i = 0; i < N; i++)
            {
                inputs[i] = Console.ReadLine();
                if (IsPalin(inputs[i]))
                {
                    cnt++;
                }
            }

            Console.WriteLine(cnt * (cnt - 1));
        }

        static bool IsPalin(string input)
        {
            int n = input.Length;

            for (int i = 0; i < n / 2; i++)
            {
                if (input[i] != input[n - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}