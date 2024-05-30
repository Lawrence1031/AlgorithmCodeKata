namespace _2592
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < 10; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (numbers.ContainsKey(num))
                {
                    numbers[num]++;
                }
                else
                {
                    numbers.Add(num, 1);
                }
            }

            int sum = 0;

            foreach (int num in numbers.Keys)
            {
                sum += num * numbers[num];
            }

            int maxCntNumber = numbers.First(x => x.Value == numbers.Values.Max()).Key;

            Console.WriteLine(sum / 10);
            Console.WriteLine(maxCntNumber);
        }
    }
}