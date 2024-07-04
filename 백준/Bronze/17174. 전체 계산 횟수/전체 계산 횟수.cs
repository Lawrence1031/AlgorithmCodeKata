namespace _17174
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);
            int addup = N;

            int cnt = 0;

            while (addup > 0)
            {
                cnt += addup;
                addup /= M;
            }

            Console.WriteLine(cnt);
        }
    }
}