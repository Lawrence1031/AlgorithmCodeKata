namespace _1297
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int D = int.Parse(inputs[0]);
            int H = int.Parse(inputs[1]);
            int W = int.Parse(inputs[2]);

            double ratio = Math.Sqrt(D * D / (double)(H * H + W * W));
            int height = (int)(H * ratio);
            int width = (int)(W * ratio);
            Console.WriteLine($"{height} {width}");
        }
    }
}