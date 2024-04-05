namespace _1436
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int cnt = 0;
            long answer = 0;

            for (long i = 666; i < int.MaxValue; i++)
            {
                string tmp = i.ToString();
                if (tmp.Contains("666"))
                {
                    cnt++;
                    answer = i;
                }
                if (cnt == N)
                {
                    break;
                }
            }

            Console.WriteLine(answer);
        }
    }
}