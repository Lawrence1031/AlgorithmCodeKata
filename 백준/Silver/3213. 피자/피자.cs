namespace _3213
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int quarter = 0;
            int half = 0;
            int threeQuarter = 0;

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();

                if (input == "1/4") quarter++;
                else if (input == "1/2")  half++;
                else threeQuarter++;
            }

            int pizzaCount = threeQuarter;
            quarter -= threeQuarter;

            if (quarter < 0) quarter = 0;

            pizzaCount += half / 2;
            half %= 2;

            if (half > 0)
            {
                pizzaCount++;
                quarter -= 2;
            }

            if (quarter > 0)
            {
                pizzaCount += (quarter + 3) / 4;
            }

            Console.WriteLine(pizzaCount);
        }
    }
}