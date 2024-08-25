namespace _22938
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs1 = Console.ReadLine().Split(' ');
            int x1 = int.Parse(inputs1[0]);
            int y1 = int.Parse(inputs1[1]);
            int r1 = int.Parse(inputs1[2]);
            string[] inputs2 = Console.ReadLine().Split(' ');
            int x2 = int.Parse(inputs2[0]);
            int y2 = int.Parse(inputs2[1]);
            int r2 = int.Parse(inputs2[2]);

            double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine(d < r1 + r2 ? "YES" : "NO");
        }
    }
}