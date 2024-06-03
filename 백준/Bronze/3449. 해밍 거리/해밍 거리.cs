namespace _3449
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string input1 = Console.ReadLine();
                string input2 = Console.ReadLine();
                int result = CalculHammingDistance(input1, input2);
                Console.WriteLine($"Hamming distance is {result}.");
            }
        }

        static int CalculHammingDistance(string a, string b)
        {
            int cnt = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    cnt++;
                }
            }

            return cnt;
        }
    }
}