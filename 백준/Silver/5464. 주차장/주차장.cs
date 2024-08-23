namespace _5464
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int n = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);

            int[] prices = new int[n];
            for (int i = 0; i < n; i++)
            {
                prices[i] = int.Parse(Console.ReadLine());
            }

            int[] cars = new int[m + 1];
            for (int i = 0; i < m; i++)
            {
                cars[i + 1] = int.Parse(Console.ReadLine());
            }

            int[] parkingLot = new int[n];
            Queue<int> watingQueue = new Queue<int>();
            int total = 0;

            for (int i = 0; i < 2 * m; i++)
            {
                int carNumber = int.Parse(Console.ReadLine());

                if (carNumber > 0)
                {
                    bool isParked = false;
                    for (int j = 0; j < n; j++)
                    {
                        if (parkingLot[j] == 0)
                        {
                            parkingLot[j] = carNumber;
                            total += prices[j] * cars[carNumber];
                            isParked = true;
                            break;
                        }
                    }

                    if (!isParked)
                    {
                        watingQueue.Enqueue(carNumber);
                    }
                }
                else
                {
                    carNumber = -carNumber;
                    for (int j = 0; j < n; j++)
                    {
                        if (parkingLot[j] == carNumber)
                        {
                            parkingLot[j] = 0;

                            if (watingQueue.Count > 0)
                            {
                                int nextCar = watingQueue.Dequeue();
                                parkingLot[j] = nextCar;
                                total += prices[j] * cars[nextCar];
                            }
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(total);
        }
    }
}