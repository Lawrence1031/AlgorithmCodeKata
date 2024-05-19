namespace _1292
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);

            List<int> numbers = new List<int>();

            for (int i = 1; i <= B; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    numbers.Add(i);
                }
            }

            Console.WriteLine(ListSum(numbers, B) - ListSum(numbers, A - 1));
        }

        static int ListSum(List<int> numbers, int idx)
        {
            int sum = 0;

            for (int i = 0; i < idx; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
}