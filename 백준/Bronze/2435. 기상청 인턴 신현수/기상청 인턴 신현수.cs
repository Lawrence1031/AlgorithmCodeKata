namespace _2435
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int K = int.Parse(inputs[1]);
            int[] temperatures = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maxTemp = int.MinValue;
            for (int i = 0; i < N - K + 1; i++)
            {
                int temp = 0;
                for (int j = i; j < i + K; j++)
                {
                    temp += temperatures[j];
                }

                if (temp > maxTemp)
                    maxTemp = temp;
            }

            Console.WriteLine(maxTemp);
        }
    }
}