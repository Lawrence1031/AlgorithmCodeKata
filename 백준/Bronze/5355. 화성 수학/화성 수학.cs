namespace _5355
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int test = 0; test < T; test++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                double N = double.Parse(inputs[0]);

                for (int i = 1; i < inputs.Length; i++)
                {
                    if (inputs[i] == "@")
                    {
                        N *= 3;
                    }
                    else if (inputs[i] == "%")
                    {
                        N += 5;
                    }
                    else if (inputs[i] == "#")
                    {
                        N -= 7;
                    }
                }

                Console.WriteLine(N.ToString("F2"));
            }
        }
    }
}