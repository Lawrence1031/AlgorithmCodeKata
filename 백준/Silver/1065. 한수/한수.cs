namespace _1065
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int cnt = 0;

            for (int i = 1; i <= N; i++)
            {
                if (IsHansu(i))
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }

        static bool IsHansu(int n)
        {
            if (n < 100)
            {
                return true;
            }

            string s = n.ToString();

            for (int i = 0; i < s.Length - 2; i++)
            {
                if (s[i + 1] - s[i] != s[i + 2] - s[i + 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}