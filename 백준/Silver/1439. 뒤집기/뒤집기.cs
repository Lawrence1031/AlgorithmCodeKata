namespace _1439
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            int oneCnt = 0;
            int zeroCnt = 0;

            for (int i = 0; i < S.Length;)
            {
                if (S[i] == '0')
                {
                    zeroCnt++;
                    while (i < S.Length && S[i] == '0')
                    {
                        i++;
                    }
                }
                else
                {
                    oneCnt++;
                    while (i < S.Length && S[i] == '1')
                    {
                        i++;
                    }
                }
            }

            Console.WriteLine(Math.Min(oneCnt, zeroCnt));
        }
    }
}