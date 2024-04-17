namespace _19532
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);
            int c = int.Parse(inputs[2]);
            int d = int.Parse(inputs[3]);
            int e = int.Parse(inputs[4]);
            int f = int.Parse(inputs[5]);

            // ax + by = c, dx + ey = f 일때, x와 y구하기
            int lower = b * d - a * e;
            int x = (b * f - e * c) / lower;
            int y = (c * d - a * f) / lower;

            Console.WriteLine(x + " " + y);
        }
    }
}