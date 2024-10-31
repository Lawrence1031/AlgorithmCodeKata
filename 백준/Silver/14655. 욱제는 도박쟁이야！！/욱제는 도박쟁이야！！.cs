namespace _14655
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] maxNum = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] minNum = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < N; i++)
            {
                maxNum[i] = Math.Abs(maxNum[i]);
                minNum[i] = Math.Abs(minNum[i]);
            }

            int sum = maxNum.Sum() + minNum.Sum();
            Console.WriteLine(sum);
        }
    }
}