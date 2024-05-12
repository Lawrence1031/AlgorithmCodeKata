namespace _4435
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int num = 0; num < T; num++)
            {
                string[] inputs1 = Console.ReadLine().Split(' ');
                string[] inputs2 = Console.ReadLine().Split(' ');

                int good = GoodScore(inputs1);
                int evil = EvilScore(inputs2);

                if (good > evil)
                {
                    Console.WriteLine($"Battle {num + 1}: Good triumphs over Evil");
                }
                else if (good < evil)
                {
                    Console.WriteLine($"Battle {num + 1}: Evil eradicates all trace of Good");
                }
                else
                {
                    Console.WriteLine($"Battle {num + 1}: No victor on this battle field");
                }
            }
        }

        static int GoodScore(string[] strs)
        {
            int score = 0;
            int[] cnts = new int[6];

            for (int i = 0; i < 6; i++)
            {
                cnts[i] = int.Parse(strs[i]);
            }

            score = 1 * cnts[0] + 2 * cnts[1] + 3 * cnts[2] +
                    3 * cnts[3] + 4 * cnts[4] + 10 * cnts[5];

            return score;
        }

        static int EvilScore(string[] strs)
        {
            int score = 0;
            int[] cnts = new int[7];

            for (int i = 0; i < 7; i++)
            {
                cnts[i] = int.Parse(strs[i]);
            }

            score = 1 * cnts[0] + 2 * cnts[1] + 2 * cnts[2] +
                    2 * cnts[3] + 3 * cnts[4] + 5 * cnts[5] +
                    10 * cnts[6];

            return score;
        }
    }
}