namespace _2108
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int N = int.Parse(input);
            int[] arr = new int[N];
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            for (int i = 0; i < N; i++)
            {
                input = Console.ReadLine(); 
                arr[i] = int.Parse(input);
                if (frequency.ContainsKey(arr[i]))
                {
                    frequency[arr[i]]++;
                }
                else
                {
                    frequency.Add(arr[i], 1);
                }
            }
            Array.Sort(arr);

            // 산술평균

            int mean = (int)Math.Round(arr.Average());
            Console.WriteLine(mean);

            // 중앙값

            int median = arr[N / 2];
            Console.WriteLine(median);

            // 최빈값

            int maxFrequency = frequency.Values.Max();
            var modes = frequency.Where(p => p.Value == maxFrequency)
                                 .Select(p => p.Key).OrderBy(p => p).ToList();
            int mode = modes.Count > 1 ? modes[1] : modes[0];
            Console.WriteLine(mode);

            // 범위

            int range = arr[N - 1] - arr[0];
            Console.WriteLine(range);
        }
    }
}