namespace _16239
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            List<int> money = new List<int>();

            for (int i = 0; i < N - 1; i++)
            {
                money.Add(i + 1);
                K -= i + 1;
            }

            money.Add(K);

            foreach (int i in money)
            {
                Console.WriteLine(i);
            }
        }
    }
}