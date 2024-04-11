using System.Text;

namespace _11658New
{

    public class FenwickTree
    {
        private int[,] tree;
        public int Size { get; private set; }

        public FenwickTree(int size)
        {
            this.Size = size;
            this.tree = new int[size + 1, size + 1];
        }

        public void Update(int x, int y, int n)
        {
            for (int i = x; i <= Size; i += (i & -i))
            {
                for (int j = y; j <= Size; j += (j & -j))
                {
                    tree[i, j] += n;
                }
            }
        }

        public int Sum(int x, int y)
        {
            int sum = 0;
            for (int i = x; i > 0; i -= (i & -i))
            {
                for (int j = y; j > 0; j -= (j & -j))
                {
                    sum += tree[i, j];
                }
            }
            return sum;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int N = int.Parse(input.Split(' ')[0]);
            int M = int.Parse(input.Split(' ')[1]);
            FenwickTree tree = new FenwickTree(N);
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= N; i++)
            {
                input = Console.ReadLine();
                var numbers = input.Split(' ').Select(int.Parse).ToArray();
                for (int j = 1; j <= N; j++)
                {
                    tree.Update(i, j, numbers[j - 1]);
                }
            }

            for (int i = 0; i < M; i++)
            {
                input = Console.ReadLine();
                var points = input.Split(' ').Select(int.Parse).ToArray();
                if (points[0] == 0)
                {
                    int x = points[1];
                    int y = points[2];
                    int c = points[3];
                    int curValue = tree.Sum(x, y) - tree.Sum(x - 1, y) - tree.Sum(x, y - 1) + tree.Sum(x - 1, y - 1);
                    tree.Update(x, y, c - curValue);
                }
                else
                {
                    int x1 = points[1];
                    int y1 = points[2];
                    int x2 = points[3];
                    int y2 = points[4];
                    int result = tree.Sum(x2, y2) - tree.Sum(x2, y1 - 1) - tree.Sum(x1 - 1, y2) + tree.Sum(x1 - 1, y1 - 1);
                    sb.AppendLine(result.ToString());
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}