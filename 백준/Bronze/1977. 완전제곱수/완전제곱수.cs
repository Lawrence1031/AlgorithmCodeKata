namespace _1977
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            var list = PerfectNumberCnt(M, N);

            if (list.Count == 0)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(list.Sum());
                Console.WriteLine(list.Min());
            }
        }

        static List<int> PerfectNumberCnt(int start, int end)
        {
            List<int> list= new List<int>();
            int first = (int)Math.Sqrt(start);

            for (int i = start; i <= end; i++)
            {
                for (int j = first; j * j <= end; j++)
                {
                    if (j * j == i)
                    {
                        list.Add(i);
                        break;
                    }
                }
            }

            return list;
        }
    }
}