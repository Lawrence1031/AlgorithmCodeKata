namespace _22015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] candies = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int largestCandy = candies.Max();
            int cnt = 0;
            foreach (int candy in candies)
            {
                cnt += largestCandy - candy;
            }

            Console.WriteLine(cnt);
        }
    }
}