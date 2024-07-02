namespace _10886
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int cuteCount = 0;
            int noCuteCount = 0;

            for (int i = 0; i < N; i++)
            {
                int cute = int.Parse(Console.ReadLine());

                if (cute == 1)
                {
                    cuteCount++;
                }
                else
                {
                    noCuteCount++;
                }
            }

            Console.WriteLine(cuteCount > noCuteCount ? "Junhee is cute!" : "Junhee is not cute!");
        }
    }
}
