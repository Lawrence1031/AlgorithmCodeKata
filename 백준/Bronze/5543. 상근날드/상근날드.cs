namespace _5543
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] hamburgers = new int[3];

            for (int i = 0; i < 3; i++)
            {
                hamburgers[i] = int.Parse(Console.ReadLine());
            }

            int[] drinks = new int[2];

            for (int i = 0; i < 2; i++)
            {
                drinks[i] = int.Parse(Console.ReadLine());
            }

            int setPrice = hamburgers.Min() + drinks.Min() - 50;
            Console.WriteLine(setPrice);
        }
    }
}