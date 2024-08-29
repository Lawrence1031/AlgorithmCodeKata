namespace _25704
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int P = int.Parse(Console.ReadLine());
            int minPrice = P;

            
            if (N >= 5)
            {
                minPrice = Math.Min(minPrice, P - 500);
            }
            if (N >= 10)
            {
                minPrice = Math.Min(minPrice, (int)(P * 0.9));
            }
            if (N >= 15)
            {
                minPrice = Math.Min(minPrice, P - 2000);
            }
            if (N >= 20)
            {
                minPrice = Math.Min(minPrice, (int)(P * 0.75));
            }

            if (minPrice < 0)
            {
                minPrice = 0;
            }

            Console.WriteLine(minPrice);
        }
    }
}