namespace _2495
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                string input = Console.ReadLine();

                char firstChar = input[0];
                int longgestCnt = 1;
                int nowCnt = 1;

                for (int j = 1; j < input.Length; j++)
                {
                    if (firstChar == input[j])
                    {
                        nowCnt++;

                        if (nowCnt > longgestCnt)
                        {
                            longgestCnt = nowCnt;
                        }
                    }
                    else
                    {
                        nowCnt = 1;
                        firstChar = input[j];
                    }
                }

                Console.WriteLine(longgestCnt);
            }
        }
    }
}