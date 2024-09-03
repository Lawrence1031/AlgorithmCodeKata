namespace _26068
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int cnt = 0;

            for (int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split('-');
                int days = int.Parse(inputs[1]);

                if (days <= 90)
                {
                    cnt++;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}