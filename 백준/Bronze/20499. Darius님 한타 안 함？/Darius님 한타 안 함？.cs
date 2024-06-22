namespace _20499
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine().Split('/').Select(int.Parse).ToArray();
            int K = inputs[0];
            int D = inputs[1];
            int A = inputs[2];

            Console.WriteLine(K + A < D || D == 0 ? "hasu" : "gosu");
        }
    }
}