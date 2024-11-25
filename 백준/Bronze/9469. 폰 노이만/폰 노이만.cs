namespace _9469
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int P = int.Parse(Console.ReadLine());
            for (int test = 0; test < P; test++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int N = int.Parse(inputs[0]);
                double D = double.Parse(inputs[1]);
                double A = double.Parse(inputs[2]);
                double B = double.Parse(inputs[3]);
                double F = double.Parse(inputs[4]);

                double flySpace = D / (A + B) * F;

                Console.WriteLine($"{N} {flySpace}");
            }
        }
    }
}