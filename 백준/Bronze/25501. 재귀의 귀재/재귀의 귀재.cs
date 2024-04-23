namespace _25501
{
    internal class Program
    {
        static int cnt = 0;

        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                cnt = 0;
                string input = Console.ReadLine();
                if (isPalindrome(input) == 1)
                {
                    Console.Write(1);
                    Console.WriteLine(" " + cnt);
                }
                else
                {
                    Console.Write(0);
                    Console.WriteLine(" " + cnt);
                }
            }
        }

        static int recursion(string s, int l, int r)
        {
            cnt++;
            if (l >= r) return 1;
            else if (s[l] != s[r]) return 0;
            else return recursion(s, l + 1, r - 1);
        }

        static int isPalindrome(string s)
        {
            return recursion(s, 0, s.Length - 1);
        }
    }
}