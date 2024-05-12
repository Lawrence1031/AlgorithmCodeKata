namespace _3058
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int[] arr = new int[7];
                string[] inputs = Console.ReadLine().Split(' ');
                int answer = 0;

                for (int j = 0; j < 7; j++)
                {
                    arr[j] = int.Parse(inputs[j]);
                }

                List<int> even = new List<int>();
                foreach (int num in arr)
                {
                    if (num % 2 == 0)
                    {
                        answer += num;
                        even.Add(num);
                    }
                }

                Console.WriteLine($"{answer} {even.Min()}");
            }
        }
    }
}