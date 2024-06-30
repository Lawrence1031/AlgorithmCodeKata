namespace _10599
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);
                int c = int.Parse(inputs[2]);
                int d = int.Parse(inputs[3]);

                if (a == 0 && b == 0 && c == 0 && d == 0)
                {
                    return;
                }

                int min = c - b;
                int max = d - a;

                Console.WriteLine($"{min} {max}");
            }
        }
    }
}