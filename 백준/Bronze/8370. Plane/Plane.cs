namespace _8370
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int n1 = int.Parse(inputs[0]);
            int k1 = int.Parse(inputs[1]);
            int n2 = int.Parse(inputs[2]);
            int k2 = int.Parse(inputs[3]);

            Console.WriteLine(n1 * k1 + n2 * k2);
        }
    }
}