namespace _13118
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] person = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] inputs = Console.ReadLine().Split(' ');
            int x = int.Parse(inputs[0]);
            int y = int.Parse(inputs[1]);
            int r = int.Parse(inputs[2]);
            int answer = -1;

            for (int i = 0; i < person.Length; i++)
            {
                if (person[i] == x)
                {
                    answer = i + 1;
                }
            }

            Console.WriteLine(answer == -1 ? 0 : answer);
        }
    }
}