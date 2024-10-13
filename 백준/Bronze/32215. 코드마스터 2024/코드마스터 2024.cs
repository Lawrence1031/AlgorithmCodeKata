namespace _32215
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int n = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);
            int k = int.Parse(inputs[2]);

            Console.WriteLine(m * (k + 1));
        }
    }
}