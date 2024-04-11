namespace _2309
{
    internal class Program
    {
        static int[] numbers = new int[9];
        static int[] selected = new int[7];
        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            FindCombination(0, 0, 0);

        }

        static void FindCombination(int idx, int start, int sum)
        {
            if (sum == 100 && idx == 7)
            {
                Array.Sort(selected);
                foreach (var num in selected)
                {
                    Console.WriteLine(num);
                }
                Environment.Exit(0);
            }

            for (int i = start; i < 9; i++)
            {
                if (idx < 7)
                {
                    selected[idx] = numbers[i];
                    FindCombination(idx + 1, i + 1, sum + numbers[i]);
                }
            }
        }
    }
}