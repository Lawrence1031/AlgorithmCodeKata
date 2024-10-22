namespace _26583
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            while((input = Console.ReadLine()) != null)
            {
                int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
                int[] newNums = new int[numbers.Length];

                for (int i = 0; i < numbers.Length; i++)
                {
                    int n = numbers[i];

                    if (i > 0) n *= numbers[i - 1];
                    if (i < numbers.Length - 1) n *= numbers[i + 1];

                    newNums[i] = n;
                }

                Console.WriteLine(string.Join(" ", newNums));
            }
        }
    }
}