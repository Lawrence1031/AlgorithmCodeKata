namespace _16719
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool[] visited = new bool[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                int j = input.Length - 1;
                while (j >= 0 && visited[j]) j--;

                int min = j;

                while (j >= 0 && !visited[j])
                {
                    min = input[min] >= input[j] ? j : min;
                    j--;
                }

                visited[min] = true;

                for (int k = 0; k < input.Length; k++)
                {
                    if (visited[k])
                    {
                        Console.Write(input[k]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}