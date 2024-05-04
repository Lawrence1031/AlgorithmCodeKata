namespace _2783
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int X = int.Parse(inputs[0]);
            double Y = int.Parse(inputs[1]);
            int N = int.Parse(Console.ReadLine());
            double price = X / Y;

            for (int i = 0; i < N; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                int Xi = int.Parse(inputs[0]);
                double Yi = int.Parse(inputs[1]);
                double otherPrice = Xi / Yi;

                if (price > otherPrice)
                {
                    price = otherPrice;
                }
            }

            Console.WriteLine((price * 1000).ToString("F2"));
        }
    }
}