namespace _10974
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            bool[] used = new bool[N];
            GeneratePermutations(N, numbers, used);
        }
        
        static void GeneratePermutations(int n, List<int> numbers, bool[] used)
        {
            if (numbers.Count == n)
            {
                Console.WriteLine(string.Join(" ", numbers));
                return;
            }

            for (int i = 0; i < n; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    numbers.Add(i + 1);
                    GeneratePermutations(n, numbers, used);

                    numbers.RemoveAt(numbers.Count - 1);
                    used[i] = false;
                }
            }
        }
    }
}