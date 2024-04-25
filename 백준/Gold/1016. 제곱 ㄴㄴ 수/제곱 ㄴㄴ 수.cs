namespace _1016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long min = long.Parse(input.Split(' ')[0]);
            long max = long.Parse(input.Split(' ')[1]);

            int length = (int)(max - min + 1);
            bool[] isSquareFree = new bool[length];
            Array.Fill(isSquareFree, true);

            for (long i = 2; i * i <= max; i++)
            {
                long square = i * i;
                long start = Math.Max(square, (min + square - 1) / square * square);

                for (long j = start; j <= max; j += square)
                {
                    isSquareFree[(int)(j - min)] = false;
                }
            }

            int cnt = 0;
            foreach (bool item in isSquareFree)
            {
                if (item)
                {
                    cnt++;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}