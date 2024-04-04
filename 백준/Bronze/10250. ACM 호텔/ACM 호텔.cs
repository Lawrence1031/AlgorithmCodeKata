namespace _10250
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int H = Convert.ToInt32(inputs[0]);
                int W = Convert.ToInt32(inputs[1]);
                int N = Convert.ToInt32(inputs[2]);

                int floor = N % H == 0 ? H : N % H;
                int room = N % H == 0 ? N / H : N / H + 1;

                Console.WriteLine($"{floor * 100 + room}");
            }
        }
    }
}