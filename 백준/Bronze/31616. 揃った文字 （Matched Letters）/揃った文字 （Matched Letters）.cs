namespace _31616
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string S = Console.ReadLine();
            char baseChar = S[0];

            for (int i = 1; i < N; i++)
            {
                if (S[i] != baseChar)
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            Console.WriteLine("Yes");
        }
    }
}