namespace _1978
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[N];
            string s = Console.ReadLine();
            int answer = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(s.Split(' ')[i]);

                if (IsPrime(arr[i]))
                {
                    answer++;
                }
            }

            Console.WriteLine(answer);
        }
        static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;
            if (n == 2)
                return true;
            if (n % 2 == 0)
                return false;

            int sqrt = (int)Math.Floor(Math.Sqrt(n));

            for (int i = 3; i <= sqrt; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}