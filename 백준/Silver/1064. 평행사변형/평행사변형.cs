using System;

class Program
{
    static void Main()
    {
        int[] positions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int x1 = positions[0];
        int y1 = positions[1];
        int x2 = positions[2];
        int y2 = positions[3];
        int x3 = positions[4];
        int y3 = positions[5];

        if ((x2 - x1) * (y3 - y1) == (y2 - y1) * (x3 - x1))
        {
            Console.WriteLine("-1");
            return;
        }

        double abLen = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        double acLen = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
        double bcLen = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));

        double[] sides = {abLen + acLen, abLen + bcLen, acLen + bcLen};
        double result = sides.Max() - sides.Min();

        Console.WriteLine(result * 2);
    }
}
