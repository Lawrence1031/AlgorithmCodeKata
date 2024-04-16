using System.Text;

namespace _3009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> dictX = new Dictionary<int, int>();
            Dictionary<int, int> dictY = new Dictionary<int, int>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 3; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int x = int.Parse(inputs[0]);
                int y = int.Parse(inputs[1]);

                if (dictX.ContainsKey(x))
                {
                    dictX[x]++;
                }
                else
                {
                    dictX[x] = 1;
                }

                if (dictY.ContainsKey(y))
                {
                    dictY[y]++;
                }
                else
                {
                    dictY[y] = 1;
                }
            }

            foreach (var item in dictX)
            {
                if (item.Value == 1)
                {
                    sb.Append(item.Key);
                }
            }

            sb.Append(' ');

            foreach (var item in dictY)
            {
                if (item.Value == 1)
                {
                    sb.Append(item.Key);
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}