namespace _9214
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int testCase = 1;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "0")
                {
                    break;
                }

                string result = FindFirstNum(input);
                Console.WriteLine($"Test {testCase}: {result}");
                testCase++;
            }
        }

        static string FindFirstNum(string s)
        {
            while (true)
            {
                string previous = GetPreviousNum(s);
                if (previous == null || previous == s)
                {
                    return s;
                }
                s = previous;
            }
        }

        static string GetPreviousNum(string s)
        {
            int i = 0;
            string result = "";

            while (i < s.Length)
            {
                char cntChar = s[i];
                int cnt = int.Parse(cntChar.ToString());
                i++;

                if (i >= s.Length)
                {
                    return null;
                }

                char numChar = s[i];
                i++;

                for (int j = 0; j < cnt; j++)
                {
                    result += numChar;
                }
            }

            if (CheckNum(result) == s)
            {
                return result;
            }
            else
            {
                return null;
            }

        }

        static string CheckNum(string s)
        {
            int cnt = 1;
            char lastChar = s[0];
            string result = "";

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == lastChar)
                {
                    cnt++;
                }
                else
                {
                    result += cnt.ToString() + lastChar;
                    lastChar = s[i];
                    cnt = 1;
                }
            }

            result += cnt.ToString() + lastChar;
            return result;
        }
    }
}