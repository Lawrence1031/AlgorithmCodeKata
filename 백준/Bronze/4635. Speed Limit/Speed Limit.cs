namespace _4635
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n = int.Parse(Console.ReadLine());

                if (n == -1)
                {
                    return;
                }

                int drivenMiles = 0;
                int hour = 0;
                for (int i = 0; i < n; i++)
                {
                    int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                    int speed = inputs[0];
                    int time = inputs[1];

                    drivenMiles += speed * (time - hour);
                    hour = time;
                }

                Console.WriteLine($"{drivenMiles} miles");
            }
        }
    }
}