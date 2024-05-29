namespace _7510
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int[] sides = new int[3];
                for (int j = 0; j < 3; j++)
                {
                    sides[j] = int.Parse(inputs[j]);
                }

                Array.Sort(sides);

                Console.WriteLine($"Scenario #{i}:");
                if (sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2])
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }

                if (i != n)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}