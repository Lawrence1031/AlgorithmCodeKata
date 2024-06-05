namespace _28238
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] attend = new int[n, 5];

            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                for (int j = 0; j < 5; j++)
                {
                    attend[i, j] = int.Parse(inputs[j]);
                }
            }

            int maxStudents = 0;
            int[] bestDays = new int[5];

            for (int d1 = 0; d1 < 4; d1++)
            {
                for (int d2 = d1 + 1; d2 < 5; d2++)
                {
                    int cnt = 0;
                    for (int i = 0; i < n; i++)
                    {
                        if (attend[i, d1] == 1 && attend[i, d2] == 1)
                        {
                            cnt++;
                        }
                    }
                    if (cnt > maxStudents)
                    {
                        maxStudents = cnt;
                        bestDays = new int[5];
                        bestDays[d1] = 1;
                        bestDays[d2] = 1;
                    }
                }
            }

            Console.WriteLine(maxStudents);
            if (maxStudents == 0)
            {
                Console.WriteLine("0 1 1 0 0");
            }
            else
            {
                Console.WriteLine(string.Join(" ", bestDays));
            }
        }
    }
}