namespace _31306
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int outCnt = 0;
            int inCnt = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if ("aeiou".Contains(input[i]))
                {
                    outCnt++;
                }

                if ("aeiouy".Contains(input[i]))
                {
                    inCnt++;
                }
            }

            Console.WriteLine($"{outCnt} {inCnt}");
        }
    }
}