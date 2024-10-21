namespace _31608
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string S = Console.ReadLine();
            string T = Console.ReadLine();
            int cnt = 0;

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] != T[i]) cnt++;
            }

            Console.WriteLine(cnt);
        }
    }
}