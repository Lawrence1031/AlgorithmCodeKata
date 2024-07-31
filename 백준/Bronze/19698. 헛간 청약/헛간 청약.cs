namespace _19698
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int W = int.Parse(inputs[1]);
            int H = int.Parse(inputs[2]);
            int L = int.Parse(inputs[3]);

            int possible = (W / L) * (H / L);
            Console.WriteLine(Math.Min(N, possible));
        }
    }
}