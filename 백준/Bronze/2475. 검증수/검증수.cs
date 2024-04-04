namespace _2475
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            int answer = 0;

            for (int i = 0; i < ss.Length; i++)
            {
                int tmp = int.Parse(ss[i]);
                answer += tmp * tmp;
            }

            Console.WriteLine(answer % 10);
        }
    }
}