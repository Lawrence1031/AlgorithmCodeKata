namespace _3578
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int eightCount = n / 2;
            int left = n % 2;

            if (eightCount == 0)
            {
                if (n == 0)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
            else
            {
                if (left == 0)
                {
                    Console.WriteLine(new string('8', eightCount));
                }
                else
                {
                    Console.Write(4);
                    Console.WriteLine(new string('8', eightCount));
                }
            }
        }
    }
}