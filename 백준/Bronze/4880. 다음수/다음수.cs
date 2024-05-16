namespace _4880
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                if (inputs[0] == "0" && inputs[1] == "0" && inputs[2] == "0")
                {
                    return;
                }

                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);
                int c = int.Parse(inputs[2]);

                if (b - a == c - b)
                {
                    Console.WriteLine($"AP {2 * c - b}");
                }
                else
                {
                    Console.WriteLine($"GP {c * c / b}");
                }
            }
        }
    }
}