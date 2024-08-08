namespace _30008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int K = int.Parse(inputs[1]);
            string[] ranks = Console.ReadLine().Split(' ');

            int[] answer = new int[K];
            int[] gradeLimit = { 4, 11, 23, 40, 60, 77, 89, 96, 100 };

            for (int i = 0; i < K; i++)
            {
                int P = int.Parse(ranks[i]) * 100 / N;
                
                for (int j = 0; j < gradeLimit.Length; j++)
                {
                    if (P <= gradeLimit[j])
                    {
                        answer[i] = j + 1;
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", answer));
        }
    }
}