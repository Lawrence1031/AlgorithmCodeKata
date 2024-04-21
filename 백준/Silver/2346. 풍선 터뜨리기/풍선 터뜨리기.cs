namespace _2346
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<int> papers = new List<int>();

            string[] inputs = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                papers.Add(int.Parse(inputs[i]));
            }

            List<int> balloons = new List<int>();
            for (int i = 1; i <= N; i++)
            {
                balloons.Add(i);
            }

            List<int> burstOrder = new List<int>();

            int curIdx = 0;

            while (balloons.Count > 0)
            {
                burstOrder.Add(balloons[curIdx]);

                int paperValue = papers[curIdx];
                balloons.RemoveAt(curIdx);
                papers.RemoveAt(curIdx);

                if (balloons.Count == 0)
                {
                    break;
                }

                if (paperValue > 0)
                {
                    curIdx = (curIdx + paperValue - 1) % balloons.Count;
                }
                else
                {
                    curIdx = (curIdx + paperValue) % balloons.Count;

                    if (curIdx < 0)
                    {
                        curIdx += balloons.Count;
                    }
                }
            }

            Console.WriteLine(string.Join(' ', burstOrder));
        }
    }
}