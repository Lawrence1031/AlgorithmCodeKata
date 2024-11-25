namespace _3578
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine(1);
            }
            else if (n == 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                int eightCount = n / 2;
                int left = n % 2;

                Console.Write(left == 1 ? "4" : "");
                Console.WriteLine(new string('8', eightCount));
            }
        }
    }
}