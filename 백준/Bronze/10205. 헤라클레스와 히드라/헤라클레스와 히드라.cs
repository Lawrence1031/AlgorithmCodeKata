using System.Text;

namespace _10205
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < K; i++)
            {
                int heads = int.Parse(Console.ReadLine());
                string inputs = Console.ReadLine();

                for (int j = 0; j < inputs.Length; j++)
                {
                    if (inputs[j] == 'c')
                    {
                        heads++;
                    }
                    else if (inputs[j] == 'b')
                    {
                        heads--;
                    }
                }
                sb.AppendLine($"Data Set {i + 1}:");
                sb.AppendLine(heads.ToString());
                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
        }
    }
}