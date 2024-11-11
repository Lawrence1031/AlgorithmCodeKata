namespace _17944
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            long T = long.Parse(inputs[1]);

            int maxArms = 2 * N;
            long cycleLength = 2 * maxArms - 2;
            long cyclePosition = (T - 1) % cycleLength + 1;
            int result;

            if (cyclePosition <= maxArms)
            {
                result = (int)cyclePosition;
            }
            else
            {
                result = (int)(2 * maxArms - cyclePosition);
            }

            Console.WriteLine(result);
        }
    }
}