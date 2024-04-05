namespace _2869
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int A = Convert.ToInt32(s.Split(' ')[0]);
            int B = Convert.ToInt32(s.Split(' ')[1]);
            int V = Convert.ToInt32(s.Split(' ')[2]);

            int answer = (V - A) / (A - B);

            if ((V - A) % (A - B) != 0)
            {
                answer++;
            }

            Console.WriteLine(answer + 1);
        }
    }
}