namespace _14924
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int S = int.Parse(inputs[0]);
            int T = int.Parse(inputs[1]);
            int D = int.Parse(inputs[2]);

            int time = D / (S * 2);
            int F = T * time;
            Console.WriteLine(F);
        }
    }
}