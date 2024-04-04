namespace _10872
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a = Convert.ToInt32(s);
            int answer = 1;

            for (int i = a; i > 1; i--)
            {
                answer *= i;
            }

            Console.WriteLine(answer);
        }
    }
}