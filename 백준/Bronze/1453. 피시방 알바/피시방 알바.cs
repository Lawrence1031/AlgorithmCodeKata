namespace _1453
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<int, int> dict = new Dictionary<int, int>();
            string[] inputs = Console.ReadLine().Split(' ');
            int cnt = 0;

            for (int i = 0; i < N; i++)
            {
                int n = int.Parse(inputs[i]);

                if (dict.ContainsKey(n))
                {
                    cnt++;
                }
                else
                {
                    dict.Add(n, 1);
                }
            }

            Console.WriteLine(cnt);
        }
    }
}