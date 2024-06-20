namespace _25592
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long stones = 0;
            int addStones = 0;

            while (stones <= N)
            {
                addStones++;
                stones += addStones;
            }

            Console.WriteLine(addStones % 2 == 0 ? 0 : stones - N);
        }
    }
}