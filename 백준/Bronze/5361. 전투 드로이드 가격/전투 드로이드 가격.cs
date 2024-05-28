namespace _5361
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] prices = { 350.34, 230.90, 190.55, 125.30, 180.90 };

            for (int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int A = int.Parse(inputs[0]);
                int B = int.Parse(inputs[1]);
                int C = int.Parse(inputs[2]);
                int D = int.Parse(inputs[3]);
                int E = int.Parse(inputs[4]);

                double sum = A * prices[0] + B * prices[1] + C * prices[2]
                                           + D * prices[3] + E * prices[4];

                Console.WriteLine($"${sum.ToString("F2")}");
            }
        }
    }
}