namespace _25756
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] inputs = Console.ReadLine().Split(' ');
            double result = 0;

            for (int i = 0; i < N; i++)
            {
                double now = double.Parse(inputs[i]);

                result = (1 - (1 - result) * (1 - now / 100));

                Console.WriteLine(result * 100);
            }
        }
    }
}