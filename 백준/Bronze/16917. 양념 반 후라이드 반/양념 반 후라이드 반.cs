namespace _16917
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);
            int C = int.Parse(inputs[2]);
            int X = int.Parse(inputs[3]);
            int Y = int.Parse(inputs[4]);
            int total = int.MaxValue;

            for (int halfChicken = 0; halfChicken <= Math.Max(X, Y); halfChicken++)
            {
                int cost = 2 * C * halfChicken + 
                           Math.Max(0, X - halfChicken) * A + 
                           Math.Max(0, Y - halfChicken) * B;
                total = Math.Min(total, cost);
            }

            Console.WriteLine(total);
        }
    }
}