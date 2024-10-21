namespace _31612
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string S = Console.ReadLine();
            int cnt = 0;

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == 'o') cnt++;
                else cnt += 2;
            }

            Console.WriteLine(cnt);
        }
    }
}