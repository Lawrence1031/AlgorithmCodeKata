namespace _16483
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            double answer = T * T / 4;
            Console.WriteLine(Math.Ceiling(answer));
        }
    }
}