namespace _10179
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                double input = double.Parse(Console.ReadLine());
                double answer = input * 0.8;
                Console.WriteLine($"${answer.ToString("F2")}");
            }
        }
    }
}