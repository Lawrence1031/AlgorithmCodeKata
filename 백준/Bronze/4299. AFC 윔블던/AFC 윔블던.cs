namespace _4299
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int sum = int.Parse(inputs[0]);
            int diff = int.Parse(inputs[1]);

            if ((sum + diff) % 2 != 0 || (sum - diff) % 2 != 0)
            {
                Console.WriteLine(-1);
                return;
            }

            int upper = (sum + diff) / 2;
            int lower = (sum - diff) / 2;

            if (upper < 0 || lower < 0)
            {
                Console.WriteLine(-1);
                return;
            }

            Console.WriteLine($"{upper} {lower}");
        }
    }
}