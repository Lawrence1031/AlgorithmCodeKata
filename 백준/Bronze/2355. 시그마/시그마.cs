namespace _2355
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            long A = int.Parse(inputs[0]);
            long B = int.Parse(inputs[1]);

            if (A > B)
            {
                long tmp = A;
                A = B;
                B = tmp;
            }

            long answer = (B * (B + 1) / 2) - (A * (A - 1) / 2);
            Console.WriteLine(answer);
        }
    }
}