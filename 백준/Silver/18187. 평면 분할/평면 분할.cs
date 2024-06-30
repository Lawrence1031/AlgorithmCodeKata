namespace _18187
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(FindMaxDivision(n));
        }

        static int FindMaxDivision(int n)
        {
            int division = 2;
            int plus = 2;
            int cnt = 1;
            bool isOdd = false;

            while (cnt != n)
            {
                division += plus;
                cnt++;

                if (isOdd)
                {
                    isOdd = false;
                    plus++;
                    continue;
                }

                if (plus % 2 == 1)
                {
                    isOdd = true;
                    continue;
                }

                plus++;
            }

            return division;
        }
    }
}