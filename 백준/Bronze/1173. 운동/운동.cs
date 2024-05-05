namespace _1173
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 운동하면 맥박이 T만큼 증가, 맥박은 M을 넘으면 안됨
            // 휴식하면 맥박이 R만큼 감소, 맥박은 m보다 작아지면 안됨
            // 운동하면 X + T, 휴식하면 X - R
            // m <= X + T / X - R <= M

            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);
            int M = int.Parse(inputs[2]);
            int T = int.Parse(inputs[3]);
            int R = int.Parse(inputs[4]);
            int totalTime = 0;
            int exerciseTime = 0;
            int now = m;

            if (m + T > M)
            {
                Console.WriteLine(-1);
                return;
            }

            while (exerciseTime < N)
            {
                if (now + T <= M)
                {
                    now += T;
                    exerciseTime++;
                }
                else
                {
                    now = Math.Max(m, now - R);
                }
                totalTime++;
            }

            Console.WriteLine(totalTime);
        }
    }
}