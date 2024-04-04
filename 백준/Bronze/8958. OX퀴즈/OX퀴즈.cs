namespace _8958
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int answer = 0;
            int tmp = 0;

            for (int i = 1; i <= n; i++)
            {
                string s = Console.ReadLine();

                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j] == 'O')
                    {
                        tmp++;
                        answer += tmp;
                    }
                    else
                    {
                        tmp = 0;
                    }
                }
                Console.WriteLine(answer);
                answer = 0;
                tmp = 0;
            }
        }
    }
}