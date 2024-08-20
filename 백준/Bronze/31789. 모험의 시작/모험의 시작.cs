namespace _31789
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] inputs = Console.ReadLine().Split(' ');
            int X = int.Parse(inputs[0]);
            int S = int.Parse(inputs[1]);

            bool isStart = false;

            for (int i = 0; i < N; i++)
            {
                string[] data = Console.ReadLine().Split(' ');
                int price = int.Parse(data[0]);
                int power = int.Parse(data[1]);

                if (price <= X && power > S)
                {
                    isStart = true;
                    break;
                }
            }

            Console.WriteLine(isStart ? "YES" : "NO");
        }
    }
}