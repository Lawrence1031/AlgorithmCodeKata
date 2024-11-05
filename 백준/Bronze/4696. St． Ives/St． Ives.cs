namespace _4696
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double n = double.Parse(Console.ReadLine());

                if (n == 0)
                {
                    return;
                }

                double answer = 1 + n + Math.Pow(n, 2) + Math.Pow(n, 3) + Math.Pow(n, 4);
                Console.WriteLine(answer.ToString("F2"));
            }
        }
    }
}