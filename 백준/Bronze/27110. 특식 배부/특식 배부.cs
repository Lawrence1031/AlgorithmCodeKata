namespace _27110
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] chickens = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int cnt = 0;

            for (int i = 0; i < chickens.Length; i++)
            {
                if (chickens[i] > N)
                {
                    cnt += N;
                }
                else
                {
                    cnt += chickens[i];
                }
            }

            Console.WriteLine(cnt);
        }
    }
}