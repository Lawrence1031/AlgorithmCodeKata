namespace _3040
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dwarfs = new int[9];
            for (int i = 0; i < 9; i++)
            {
                dwarfs[i] = int.Parse(Console.ReadLine());
            }

            int sum = dwarfs.Sum();
            List<int> result = new List<int>();

            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 9; j++)
                {
                    if (sum - dwarfs[i] - dwarfs[j] == 100)
                    {
                        for (int k = 0; k < 9; k++)
                        {
                            if (k != i && k != j)
                            {
                                result.Add(dwarfs[k]);
                            }
                        }

                        foreach (int k in result)
                        {
                            Console.WriteLine(k);
                        }
                        return;
                    }
                }
            }
        }
    }
}