namespace _32710
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            HashSet<int> nums = new HashSet<int> { 1 };

            for (int i = 2; i <= 9; i++)
            {
                nums.Add(i);

                for (int j = 1; j <= 9; j++)
                {
                    nums.Add(i * j);
                }
            }

            Console.WriteLine(nums.Contains(N) ? "1" : "0");
        }
    }
}