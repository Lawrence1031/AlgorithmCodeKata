namespace _31867
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            string K = Console.ReadLine();

            int oddCnt = 0;
            int evenCnt = 0;

            foreach (char c in K)
            {
                int digit = c - '0';
                if (digit % 2 == 1)
                {
                    oddCnt++;
                }
                else
                {
                    evenCnt++;
                }
            }

            Console.WriteLine(oddCnt == evenCnt ? -1 : (oddCnt > evenCnt ? 1 : 0));
        }
    }
}