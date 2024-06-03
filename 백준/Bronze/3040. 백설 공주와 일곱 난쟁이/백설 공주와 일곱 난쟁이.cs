namespace _3040
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> dwarfs = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                dwarfs.Add(int.Parse(Console.ReadLine()));
            }

            int sum = dwarfs.Sum();

            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 9; j++)
                {
                    if (sum - dwarfs[i] - dwarfs[j] == 100)
                    {
                        dwarfs.RemoveAt(j);
                        dwarfs.RemoveAt(i);

                        foreach (int k in dwarfs)
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