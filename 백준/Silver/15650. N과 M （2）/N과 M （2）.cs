namespace _15650
{
    internal class Program
    {
        static List<int> curList = new List<int>();
        static int N, M;
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            N = int.Parse(inputs[0]);
            M = int.Parse(inputs[1]);

            GenerateList(1, 0);
        }

        static void GenerateList(int start, int num)
        {
            if (num == M)
            {
                Console.WriteLine(string.Join(" ", curList));
                return;
            }

            for (int i = start; i <= N; i++)
            {
                curList.Add(i);

                GenerateList(i + 1, num + 1);

                curList.RemoveAt(curList.Count - 1);
            }
        }
    }
}