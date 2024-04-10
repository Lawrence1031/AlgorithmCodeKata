using System.Text;

namespace _1620
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int N = int.Parse(input.Split(' ')[0]);
            int M = int.Parse(input.Split(' ')[1]);
            StringBuilder sb = new StringBuilder();

            Dictionary<string, int> pokemon = new Dictionary<string, int>();
            Dictionary<int, string> indexPokemon = new Dictionary<int, string>();

            for (int i = 1; i <= N; i++)
            {
                input = Console.ReadLine();
                pokemon[input] = i;
                indexPokemon[i] = input;
            }

            for (int i = 0; i < M; i++)
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out int num))
                {
                    sb.AppendLine(indexPokemon[num]);
                }
                else
                {
                    sb.AppendLine(pokemon[input].ToString());
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}