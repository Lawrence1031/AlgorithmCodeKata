using System.Text;

namespace _5358
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            while ((input = Console.ReadLine()) != null)
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == 'e')
                    {
                        sb.Append('i');
                    }
                    else if (input[i] == 'E')
                    {
                        sb.Append('I');
                    }
                    else if (input[i] == 'i')
                    {
                        sb.Append('e');
                    }
                    else if (input[i] == 'I')
                    {
                        sb.Append('E');
                    }
                    else
                    {
                        sb.Append(input[i]);
                    }
                }

                Console.WriteLine(sb.ToString());
            }
        }
    }
}