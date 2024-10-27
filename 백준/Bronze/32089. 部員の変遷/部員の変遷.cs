namespace _32089
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    return;
                }

                int[] enrolls = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int maxMem = 0;

                for (int i = 0; i < enrolls.Length - 2; i++)
                {
                    int now = enrolls[i] + enrolls[i + 1] + enrolls[i + 2];
                    maxMem = Math.Max(maxMem, now);
                }

                Console.WriteLine(maxMem);
            }
        }
    }
}