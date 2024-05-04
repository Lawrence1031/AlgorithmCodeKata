namespace _2991
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);
            int C = int.Parse(inputs[2]);
            int D = int.Parse(inputs[3]);
            inputs = Console.ReadLine().Split(' ');
            int P = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);
            int N = int.Parse(inputs[2]);

            Console.WriteLine(CheckAttack(P, A, B, C, D));
            Console.WriteLine(CheckAttack(M, A, B, C, D));
            Console.WriteLine(CheckAttack(N, A, B, C, D));
        }

        static int CheckAttack(int time, int A, int B, int C, int D)
        {
            int attacks = 0;
            if (IsAggressive(time, A, B)) attacks++;
            if (IsAggressive(time, C, D)) attacks++;
            return attacks;            
        }

        static bool IsAggressive(int time, int aggressive, int rest)
        {
            int period = aggressive + rest;
            int modTime = time % period;
            return modTime <= aggressive && modTime > 0;
        }
    }
}