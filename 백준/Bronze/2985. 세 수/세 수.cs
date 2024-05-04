namespace _2985
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);
            int C = int.Parse(inputs[2]);

            if (A + B == C)
                Console.WriteLine($"{A}+{B}={C}");
            else if (A - B == C)
                Console.WriteLine($"{A}-{B}={C}");
            else if (A * B == C)
                Console.WriteLine($"{A}*{B}={C}");
            else if (A / B == C)
                Console.WriteLine($"{A}/{B}={C}");

            if (A == B + C)
                Console.WriteLine($"{A}={B}+{C}");
            else if (A == B - C)
                Console.WriteLine($"{A}={B}-{C}");
            else if (A == B * C)
                Console.WriteLine($"{A}={B}*{C}");
            else if (A == B / C)
                Console.WriteLine($"{A}={B}/{C}");
        }
    }
}