namespace _17207
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[5, 5];
            int[,] B = new int[5, 5];
            string[] names = { "Inseo", "Junsuk", "Jungwoo", "Jinwoo", "Youngki" };

            for (int i = 0; i < 5; i++)
            {
                int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < 5; j++)
                {
                    A[i, j] = inputs[j];
                }
            }

            for (int i = 0; i < 5; i++)
            {
                int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < 5; j++)
                {
                    B[i, j] = inputs[j];
                }
            }

            int[] totalWork = new int[5];

            for (int person = 0; person < 5; person++)
            {
                for (int work = 0; work < 5; work++)
                {
                    int works = 0;
                    for (int i = 0; i < 5; i++)
                    {
                        works += A[person, i] * B[i, work];
                    }
                    totalWork[person] += works;
                }
            }

            int minWork = totalWork[0];
            int minIndex = 0;
            for (int i = 0; i < 5; i++)
            {
                if (totalWork[i] < minWork || (totalWork[i] == minWork && i > minIndex))
                {
                    minWork = totalWork[i];
                    minIndex = i;
                }
            }

            Console.WriteLine(names[minIndex]);
        }
    }
}