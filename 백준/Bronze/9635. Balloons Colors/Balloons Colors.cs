namespace _9635
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int test = 0; test < T; test++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int N = int.Parse(inputs[0]);
                int X = int.Parse(inputs[1]);
                int Y = int.Parse(inputs[2]);
                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                int first = numbers.First();
                int last = numbers.Last();

                if (first == X && last == Y)
                {
                    Console.WriteLine("BOTH");
                }
                else if (first == X && last != Y)
                {
                    Console.WriteLine("EASY");
                }
                else if (first != X && last == Y)
                {
                    Console.WriteLine("HARD");
                }
                else
                {
                    Console.WriteLine("OKAY");
                }
            }
        }
    }
}