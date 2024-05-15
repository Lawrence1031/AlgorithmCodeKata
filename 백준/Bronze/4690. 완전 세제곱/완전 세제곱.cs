namespace _4690
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 100; a++)
            {
                int aCube = a * a * a;
                for (int b = 2; b < a; b++)
                {
                    int bCube = b * b * b;
                    for (int c = b; c < a; c++)
                    {
                        int cCube = c * c * c;
                        for (int d = c; d < a; d++)
                        {
                            int dCube = d * d * d;

                            if (aCube == bCube + cCube + dCube)
                            {
                                Console.WriteLine($"Cube = {a}, Triple = ({b},{c},{d})");
                            }
                        }
                    }
                }
            }
        }
    }
}