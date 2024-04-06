namespace _9012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] s = new string[N];
            
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = Console.ReadLine();

                if (isVPS(s[i]))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }

        static private bool isVPS(string s)
        {
            int cnt = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    cnt++;
                }
                else
                {
                    cnt--;
                }

                if (cnt < 0)
                {
                    return false;
                }                    
            }

            if (cnt != 0)
            {
                return false;
            }

            return true;
        }
    }
}