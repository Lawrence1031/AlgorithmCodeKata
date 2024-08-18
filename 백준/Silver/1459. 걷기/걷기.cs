namespace _1459
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            long X = long.Parse(inputs[0]);
            long Y = long.Parse(inputs[1]);
            long W = long.Parse(inputs[2]);
            long S = long.Parse(inputs[3]);

            long time1 = (X + Y) * W;
            long time2 = Math.Min(X, Y) * S + Math.Abs(X - Y) * W;
            long time3 = 0;

            if ((X + Y) % 2 == 0)
            {
                time3 = Math.Max(X, Y) * S;
            }
            else
            {
                time3 = (Math.Max(X, Y) - 1) * S + W;
            }

            long answer = Math.Min(time1, Math.Min(time2, time3));
            Console.WriteLine(answer);
        }
    }
}