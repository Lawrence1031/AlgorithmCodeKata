namespace _15829
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int L = Convert.ToInt32(Console.ReadLine());
            long answer = 0;
            long M = 1234567891;
            int r = 31;
            long rPow = 1;

            string s = Console.ReadLine();

            for (int i = 0; i < L; i++)
            {
                int charInt = s[i] - 96;
                answer = (answer + charInt * rPow) % M;

                rPow = (rPow * r) % M;
            }

            Console.WriteLine(answer);
        }
    }
}