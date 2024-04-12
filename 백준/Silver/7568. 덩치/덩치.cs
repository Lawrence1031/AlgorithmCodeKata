namespace _7568
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<Tuple<int, int>> list = new List<Tuple<int, int>>();

            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int weight = int.Parse(input[0]);
                int height = int.Parse(input[1]);
                list.Add(new Tuple<int, int>(weight, height));
            }

            int[] ranks = new int[N];

            for (int i = 0; i < N; i++)
            {
                int rank = 1;
                for (int j = 0; j < N; j++)
                {
                    if (i != j)
                    {
                        if (list[i].Item1 < list[j].Item1 && list[i].Item2 < list[j].Item2)
                        {
                            rank++;
                        }
                    }
                }
                ranks[i] = rank;
            }

            Console.WriteLine(string.Join(" ", ranks));
        }
    }
}