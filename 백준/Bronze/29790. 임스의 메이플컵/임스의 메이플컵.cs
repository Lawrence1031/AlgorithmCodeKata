namespace _29790
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int U = int.Parse(inputs[1]);
            int L = int.Parse(inputs[2]);

            if (N >= 1000)
            {
                if (U < 8000 && L < 260)
                {
                    Console.WriteLine("Good");
                }
                else
                {
                    Console.WriteLine("Very Good");
                }
            }
            else
            {
                Console.WriteLine("Bad");
            }
        }
    }
}