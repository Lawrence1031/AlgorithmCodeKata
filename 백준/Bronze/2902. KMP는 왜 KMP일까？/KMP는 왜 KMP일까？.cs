using System.Text;

namespace _2902
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split('-');
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < inputs.Length; i++)
            {
                sb.Append(inputs[i][0]);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}