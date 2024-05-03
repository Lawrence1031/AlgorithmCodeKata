namespace _2765
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.1415927;
            int cnt = 1;

            while (true)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                double diameter = double.Parse(inputs[0]);
                int rotationNum = int.Parse(inputs[1]);
                double time = double.Parse(inputs[2]);

                if (rotationNum == 0)
                {
                    return;
                }

                double distance = pi * diameter * rotationNum / 63360;
                double MPH = distance / time * 3600;

                Console.WriteLine($"Trip #{cnt}: {distance.ToString("F2")} {MPH.ToString("F2")}");
                cnt++;
            }
        }
    }
}