namespace _2153
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int cnt = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'a' && input[i] <= 'z')
                {
                    cnt += input[i] - 'a' + 1;
                }
                else
                {
                    cnt += input[i] - 'A' + 27;
                }
            }

            if (IsPrime(cnt))
            {
                Console.WriteLine("It is a prime word.");
            }
            else
            {
                Console.WriteLine("It is not a prime word.");
            }
        }

        static bool IsPrime(int n)
        {
            if (n == 1) return true;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            
            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}