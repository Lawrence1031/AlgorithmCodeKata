using System.Text;

namespace _11005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);
            StringBuilder sb = new StringBuilder();

            while (N > 0)
            {
                int num = N % B;

                if (num >= 10)
                {
                    sb.Insert(0, (char)(num + 55));
                }
                else
                {
                    sb.Insert(0, num.ToString());
                }

                N = N / B;
            }

            Console.WriteLine(sb.ToString());
        }
    }
}