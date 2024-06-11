using System.Text;

namespace _9325
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int S = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());
                long price = S;

                for (int j = 0; j < n; j++)
                {
                    string[] inputs = Console.ReadLine().Split(' ');
                    int q = int.Parse(inputs[0]);
                    int p = int.Parse(inputs[1]);

                    price += p * q;
                }

                Console.WriteLine(price);
            }
        }
    }
}