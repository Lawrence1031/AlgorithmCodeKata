namespace _10474
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

                if (a == 0 && b == 0)
                {
                    return;
                }

                int qout = a / b;
                int remain = a % b;

                Console.WriteLine($"{qout} {remain} / {b}");
            }
        }
    }
}