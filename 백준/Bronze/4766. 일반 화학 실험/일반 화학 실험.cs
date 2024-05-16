namespace _4766
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> temperature = new List<double>();
            while (true)
            {
                double input = double.Parse(Console.ReadLine());

                if (input == 999)
                {
                    for (int i = 1; i < temperature.Count; i++)
                    {
                        string answer = (temperature[i] - temperature[i - 1]).ToString("F2");
                        Console.WriteLine(answer);
                    }
                    return;
                }

                temperature.Add(input);
            }
        }
    }
}