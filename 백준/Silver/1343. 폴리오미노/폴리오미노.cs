namespace _1343
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> list = new List<string>();

            for (int i = 0; i < input.Length;)
            {
                if (input[i] == 'X')
                {
                    int cnt = 0;
                    while (i + cnt < input.Length && input[i + cnt] == 'X')
                    {
                        cnt++;
                    }

                    if (cnt % 2 != 0)
                    {
                        Console.WriteLine(-1);
                        return;
                    }

                    int originalCnt = cnt;

                    while (cnt >= 4)
                    {
                        list.Add("AAAA");
                        cnt -= 4;
                    }

                    if (cnt == 2)
                    {
                        list.Add("BB");
                    }

                    i += originalCnt;
                }
                else
                {
                    list.Add(".");
                    i++;
                }
            }

            Console.WriteLine(string.Join("", list));
        }
    }
}