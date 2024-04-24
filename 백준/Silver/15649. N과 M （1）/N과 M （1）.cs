namespace _15649
{
    internal class Program
    {
        static List<int> curList = new List<int>();
        static bool[] usedNum;
        static int N, M;
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            N = int.Parse(inputs[0]);
            M = int.Parse(inputs[1]);

            usedNum = new bool[N + 1];

            GenerateList(0);
        }

        static void GenerateList(int num)
        {
            if (num == M)
            {
                Console.WriteLine(string.Join(" ", curList));
                return;
            }

            for (int i = 1; i <= N; i++)
            {
                if (!usedNum[i])
                {
                    usedNum[i] = true;
                    curList.Add(i);

                    GenerateList(num + 1);

                    usedNum[i] = false;
                    curList.RemoveAt(curList.Count - 1);
                }
            }
        }
    }
}