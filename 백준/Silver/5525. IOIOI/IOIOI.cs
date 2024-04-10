namespace _5525
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            string S = Console.ReadLine();

            string PN = string.Concat(Enumerable.Repeat("IO", N)) + "I";

            int cnt = 0;
            int idx = 0;

            while ((idx = S.IndexOf(PN, idx)) != -1)
            {
                cnt++;
                idx++;
            }

            Console.WriteLine(cnt);
        }
    }
}