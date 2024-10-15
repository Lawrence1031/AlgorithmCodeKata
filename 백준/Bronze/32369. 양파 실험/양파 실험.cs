namespace _32369
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int n = int.Parse(inputs[0]);
            int A = int.Parse(inputs[1]);
            int B = int.Parse(inputs[2]);

            int compli = 1;
            int blame = 1;

            for (int i = 0; i < n; i++)
            {
                compli += A;
                blame += B;

                if (compli < blame)
                {
                    int tmp = compli;
                    compli = blame;
                    blame = tmp;
                }
                else if (compli == blame)
                {
                    blame--;
                }
            }

            Console.WriteLine($"{compli} {blame}");
        }
    }
}