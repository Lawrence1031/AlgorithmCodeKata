namespace _7789
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int Number = int.Parse(inputs[0]);
            int newNumber = int.Parse(inputs[1] + inputs[0]);

            if (IsPrime(Number) && IsPrime(newNumber))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static bool IsPrime(int n)
        {
            for (int i = 2; i * i <= n; i++)
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