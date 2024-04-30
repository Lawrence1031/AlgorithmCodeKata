namespace _3046
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');

            int R1 = int.Parse(inputs[0]);
            int S = int.Parse(inputs[1]);

            int R2 = 2 * S - R1;

            Console.WriteLine(R2);
        }
    }
}