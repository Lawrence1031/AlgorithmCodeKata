namespace _2920
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int[] num = new int[s.Length];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(s[i]);
            }

            int asCnt = 0;
            int deCnt = 0;

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == i + 1)
                {
                    asCnt++;
                }
                else if (num[i] == 8 - i)
                {
                    deCnt++;
                }
            }

            if (asCnt == 8)
            {
                Console.WriteLine("ascending");
            }
            else if (deCnt == 8)
            {
                Console.WriteLine("descending");
            }
            else
            {
                Console.WriteLine("mixed");
            }
        }
    }
}