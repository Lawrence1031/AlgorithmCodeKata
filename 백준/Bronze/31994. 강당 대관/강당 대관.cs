namespace _31994
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 0; i < 7; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                dict[inputs[0]] = int.Parse(inputs[1]);
            }

            string answer = dict.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            Console.WriteLine(answer);
        }
    }
}