namespace _9366
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Array.Sort(numbers);
                string triangle = CheckTriangle(numbers);
                Console.WriteLine($"Case #{i + 1}: {triangle}");
            }
        }

        static string CheckTriangle(int[] numbers)
        {
            
            if (numbers[2] >= numbers[0] + numbers[1])
            {
                return "invalid!";
            }
            else if (numbers[0] == numbers[1] && numbers[1] == numbers[2])
            {
                return "equilateral";
            }
            else if ((numbers[0] == numbers[1] && numbers[1] != numbers[2]) ||
                     (numbers[0] == numbers[2] && numbers[0] != numbers[1]) ||
                     (numbers[1] == numbers[2] && numbers[2] != numbers[0]))
            {
                return "isosceles";
            }
            else
            {
                return "scalene";
            }
        }
    }
}