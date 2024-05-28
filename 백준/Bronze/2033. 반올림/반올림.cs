namespace _2033
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            int cnt = 0;

            while (N > 10)
            {
                N = Math.Round(N / 10, MidpointRounding.AwayFromZero);
                cnt++;
            }

            Console.WriteLine(N * Math.Pow(10, cnt));            
        }
    }
}