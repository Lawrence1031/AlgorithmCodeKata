namespace _10434
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int P = int.Parse(Console.ReadLine());
            for (int i = 0; i < P; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int cnt = int.Parse(inputs[0]);
                int num = int.Parse(inputs[1]);
                bool IsOk = true;

                if (!IsPrime(num))
                {
                    IsOk = false;
                }
                else
                {
                    if (!IsHappy(num))
                    {
                        IsOk = false;
                    }
                }

                Console.Write($"{cnt} {num} ");
                Console.WriteLine(IsOk ? "YES" : "NO");
            }

        }

        static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            int sqrt = (int)Math.Floor(Math.Sqrt(n));

            for (int i = 3; i <= sqrt; i += 2)
            {
                if (n % i == 0) return false;
            }

            return true;
        }

        static bool IsHappy(int n)
        {
            HashSet<int> seedNum = new HashSet<int>();

            while (n != 1 && !seedNum.Contains(n))
            {
                seedNum.Add(n);
                n = SumOfDigits(n);
            }

            return n == 1;
        }

        static int SumOfDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                sum += digit * digit;
                n /= 10;
            }

            return sum;
        }
    }
}