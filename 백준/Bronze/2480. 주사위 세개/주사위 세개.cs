namespace _2480
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 같은 눈 3개 -> 10000 + 같은 눈 * 1000
            // 같은 눈 2개 -> 1000 + 같은 눈 * 100
            // 같은 눈 X -> 가장 큰 눈 * 100

            string[] inputs = Console.ReadLine().Split(' ');
            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);
            int C = int.Parse(inputs[2]);
            int reward = 0;

            if (A == B && B == C)
            {
                reward = 10000 + A * 1000;
                Console.WriteLine(reward);
                return;
            }
            else if ((A == B && B != C) || (A != B && A == C))
            {
                reward = 1000 + A * 100;
                Console.WriteLine(reward);
                return;
            }
            else if ((A != B && B == C))
            {
                reward = 1000 + B * 100;
                Console.WriteLine(reward);
                return;
            }
            else
            {
                int value = A >= B ? A : B;
                reward = (value >= C ? value : C) * 100;
                Console.WriteLine(reward);
                return;
            }
        }
    }
}