namespace _2592
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            int sum = 0;
            int mode = 0;
            int maxCnt = 0;

            for (int i = 0; i < 10; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if (numbers.ContainsKey(num))
                {
                    numbers[num]++;
                }
                else
                {
                    numbers.Add(num, 1);
                }

                if (numbers[num] > maxCnt)
                {
                    maxCnt = numbers[num];
                    mode = num;
                }
            }

            Console.WriteLine(sum / 10);
            Console.WriteLine(mode);
        }
    }
}