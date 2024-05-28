namespace _5596
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] min = Console.ReadLine().Split(' ');
            string[] man = Console.ReadLine().Split(' ');
            int minSum = 0;
            int manSum = 0;

            for (int i = 0; i < 4; i++)
            {
                minSum += int.Parse(min[i]);
                manSum += int.Parse(man[i]);
            }

            Console.WriteLine(Math.Max(minSum, manSum));
        }
    }
}