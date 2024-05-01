namespace _2476
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] reward = new int[N];

            for (int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int num1 = int.Parse(inputs[0]);
                int num2 = int.Parse(inputs[1]);
                int num3 = int.Parse(inputs[2]);

                if (num1 == num2 && num1 == num3)
                {
                    reward[i] = 10000 + num1 * 1000;
                }
                else if ((num1 == num2 && num1 != num3) || (num1 != num2 && num1 == num3))
                {
                    reward[i] = 1000 + num1 * 100;
                }
                else if (num1 != num2 && num2 == num3)
                {
                    reward[i] = 1000 + num2 * 100;
                }
                else
                {
                    reward[i] = Math.Max(Math.Max(num1, num2), num3) * 100;
                }
            }

            Console.WriteLine(reward.Max());
        }
    }
}