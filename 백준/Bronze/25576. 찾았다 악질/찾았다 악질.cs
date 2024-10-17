namespace _25576
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);
            int[] baseNum = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int cnt = 0;

            for (int i = 0; i < N - 1; i++)
            {
                int[] nowNum = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int total = 0;

                for (int j = 0; j < nowNum.Length; j++)
                {
                    total += Math.Abs(nowNum[j] - baseNum[j]);
                }

                if (total > 2000) cnt++;
            }

            Console.WriteLine((double)(N - 1) / 2 > cnt ? "NO" : "YES");
        }
    }
}