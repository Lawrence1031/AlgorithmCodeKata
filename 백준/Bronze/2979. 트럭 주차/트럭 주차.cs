namespace _2979
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);
            int C = int.Parse(inputs[2]);

            int[,] trucks = new int[3, 2];
            for (int i = 0; i < 3; i++)
            {
                string[] times = Console.ReadLine().Split(' ');
                trucks[i, 0] = int.Parse(times[0]);
                trucks[i, 1] = int.Parse(times[1]);
            }

            int[] timeSlots = new int[101];
            for (int i = 0; i < 3; i++)
            {
                for (int t = trucks[i, 0]; t < trucks[i, 1]; t++)
                {
                    timeSlots[t]++;
                }
            }

            int totalFee = 0;
            for (int t = 1; t <= 100; t++)
            {
                if (timeSlots[t] == 1)
                {
                    totalFee += A;
                }
                else if (timeSlots[t] == 2)
                {
                    totalFee += B * 2;
                }
                else if (timeSlots[t] == 3)
                {
                    totalFee += C * 3;
                }
            }

            Console.WriteLine(totalFee);
        }
    }
}