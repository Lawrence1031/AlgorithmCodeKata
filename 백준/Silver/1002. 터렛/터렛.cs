namespace _1002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int x1 = int.Parse(inputs[0]);
                int y1 = int.Parse(inputs[1]);
                int r1 = int.Parse(inputs[2]);
                int x2 = int.Parse(inputs[3]);
                int y2 = int.Parse(inputs[4]);
                int r2 = int.Parse(inputs[5]);

                double distance = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
                double sumLength = Math.Pow(r1 + r2, 2);
                double diffLength = Math.Pow(r1 - r2, 2);

                if (x1 == x2 && y1 == y2 && r1 == r2)
                {
                    Console.WriteLine(-1);
                }
                else if (distance == sumLength || distance == diffLength)
                {
                    Console.WriteLine(1);
                }
                else if (distance > diffLength && distance < sumLength)
                {
                    Console.WriteLine(2);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}