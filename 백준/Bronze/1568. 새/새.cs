namespace _1568
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int remainBirds = N;
            int cnt = 1;
            int time = 0;
            
            while (remainBirds > 0)
            {
                if (remainBirds >= cnt)
                {
                    remainBirds -= cnt;
                    cnt++;
                    time++;
                }
                else
                {
                    cnt = 1;
                }
            }

            Console.WriteLine(time);
        }
    }
}