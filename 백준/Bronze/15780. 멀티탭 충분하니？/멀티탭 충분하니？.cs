namespace _15780
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int K = int.Parse(inputs[1]);
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            double available = arr.Select(x => Math.Ceiling(x / 2.0)).Sum();
            Console.WriteLine(available >= N ? "YES" : "NO");
        }
    }
}