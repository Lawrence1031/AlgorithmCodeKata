namespace _1110
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int N = int.Parse(input);

            int originalNumber = N;
            int cnt = 0;

            while (true)
            {
                int sum = (N / 10) + (N % 10);
                N = (N % 10) * 10 + (sum % 10);
                cnt++;

                if (N == originalNumber)
                {
                    Console.WriteLine(cnt);
                    return;
                }
            }
        }
    }
}