using System.Text;

namespace _6321
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                StringBuilder sb = new StringBuilder();

                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] + 1 > 'Z')
                    {
                        sb.Append('A');
                    }
                    else
                    {
                        sb.Append((char)(input[j] + 1));
                    }
                }

                Console.WriteLine($"String #{i + 1}");
                Console.WriteLine(sb.ToString());
                
                if (i != N)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}