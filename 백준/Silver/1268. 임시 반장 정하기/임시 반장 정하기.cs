namespace _1268
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int[,] stuClass = new int[students, 5];

            for (int i = 0; i < students; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                for (int j = 0; j < 5; j++)
                {
                    stuClass[i, j] = int.Parse(inputs[j]);
                }
            }

            int maxSameClassCnt = 0;
            int tmpPresident = 1;

            for (int i = 0; i < students; i++)
            {
                int sameClassCnt = 0;

                for (int j = 0; j < students; j++)
                {
                    if (i == j) continue;

                    for (int k = 0; k < 5; k++)
                    {
                        if (stuClass[i, k] == stuClass[j, k])
                        {
                            sameClassCnt++;
                            break;
                        }
                    }
                }

                if (sameClassCnt > maxSameClassCnt)
                {
                    maxSameClassCnt = sameClassCnt;
                    tmpPresident = i + 1;
                }
            }

            Console.WriteLine(tmpPresident);
        }
    }
}