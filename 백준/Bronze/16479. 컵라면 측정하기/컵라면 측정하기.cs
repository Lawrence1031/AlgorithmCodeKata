namespace _16479
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());
            string[] inputs = Console.ReadLine().Split(' ');
            int D1 = int.Parse(inputs[0]);
            int D2 = int.Parse(inputs[1]);

            Console.WriteLine(Math.Pow(K, 2) - Math.Pow((double)(D1 - D2) / 2, 2));
        }
    }
}