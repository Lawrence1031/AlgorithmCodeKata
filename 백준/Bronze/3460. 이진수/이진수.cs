using System.Text;

namespace _3460
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int n = int.Parse(Console.ReadLine());
                string binary = Convert.ToString(n, 2);
                StringBuilder sb = new StringBuilder();

                for (int j = 0; j < binary.Length; j++)
                {
                    if (binary[binary.Length - 1 - j] == '1')
                    {
                        sb.Append(j + " ");
                    }
                }
        
                Console.WriteLine(sb.ToString().Trim());
            }
        }
    }
}