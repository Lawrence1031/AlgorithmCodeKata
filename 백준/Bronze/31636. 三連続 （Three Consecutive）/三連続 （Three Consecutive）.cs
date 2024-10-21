namespace _31636
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string S = Console.ReadLine();

            for (int i = 1; i < S.Length - 1; i++)
            {
                if (S[i - 1] == 'o' && S[i] == 'o' && S[i + 1] == 'o')
                {
                    Console.WriteLine("Yes");
                    return;
                }
            }

            Console.WriteLine("No");
        }
    }
}