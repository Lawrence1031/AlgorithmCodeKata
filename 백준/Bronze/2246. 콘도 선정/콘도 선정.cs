namespace _2246
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<(int Distance, int Price)> condos = new List<(int Distance, int Price)> ();

            for (int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int D = int.Parse(inputs[0]);
                int C = int.Parse(inputs[1]);
                condos.Add((D, C));
            }

            int cnt = 0;

            for (int i = 0; i < N; i++)
            {
                bool isChip = true;

                for (int j = 0; j < N; j++)
                {
                    if (i != j)
                    {
                        if ((condos[j].Distance < condos[i].Distance && condos[j].Price <= condos[i].Price) ||
                            (condos[j].Price < condos[i].Price && condos[j].Distance <= condos[i].Distance))
                        {
                            isChip = false;
                            break;
                        }
                    }
                }

                if (isChip)
                {
                    cnt++;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}