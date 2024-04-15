namespace _1316
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int cnt = 0;

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                if (IsGroupWord(input))
                {
                    cnt++;
                }
            }

            Console.WriteLine(cnt);

        }

        static bool IsGroupWord(string input)
        {
            HashSet<char> words = new HashSet<char>();

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (words.Contains(ch))
                {
                    if (input[i - 1] != ch)
                    {
                        return false;
                    }
                }
                else
                {
                    words.Add(ch);
                }
            }

            return true;
        }
    }
}