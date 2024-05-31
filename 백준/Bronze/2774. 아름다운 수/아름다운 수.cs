namespace _2774
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string input = Console.ReadLine();
                Dictionary<char, int> numbers = new Dictionary<char, int>();

                for (int j = 0; j < input.Length; j++)
                {
                    if (numbers.ContainsKey(input[j]))
                    {
                        numbers[input[j]]++;
                    }
                    else
                    {
                        numbers.Add(input[j], 1);
                    }
                }

                Console.WriteLine(numbers.Values.Count);
            }
        }
    }
}