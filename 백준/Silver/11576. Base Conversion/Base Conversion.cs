using System.Text;

namespace _11576
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);
            int m = int.Parse(Console.ReadLine());
            inputs = Console.ReadLine().Split(' ');

            double number = 0;
            for (int i = 0; i < m; i++)
            {
                number = number * A + int.Parse(inputs[i]);
            }

            StringBuilder sb = new StringBuilder();
            while (number > 0)
            {
                sb.Insert(0, (number % B) + " ");
                number = (int)(number / B);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}