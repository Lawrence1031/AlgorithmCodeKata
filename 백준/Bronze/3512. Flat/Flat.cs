namespace _3512
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int n = int.Parse(inputs[0]);
            int cost = int.Parse(inputs[1]);
            int totalSpace = 0;
            int bedroomCnt = 0;
            int balconyCnt = 0;

            for (int i = 0; i < n; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                totalSpace += int.Parse(inputs[0]);

                if (inputs[1] == "bedroom")
                {
                    bedroomCnt += int.Parse(inputs[0]);
                }

                if (inputs[1] == "balcony")
                {
                    balconyCnt += int.Parse(inputs[0]);
                }
            }

            double totalCost = (totalSpace - balconyCnt * 0.5) * cost;

            Console.WriteLine(totalSpace);
            Console.WriteLine(bedroomCnt);
            Console.WriteLine(totalCost);
        }
    }
}