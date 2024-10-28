namespace _5074
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                if (inputs[0] == "00:00" && inputs[1] == "00:00")
                {
                    return;
                }

                int startHour = int.Parse(inputs[0].Split(":")[0]);
                int startMin = int.Parse(inputs[0].Split(":")[1]);
                int duraHour = int.Parse(inputs[1].Split(":")[0]);
                int duraMin = int.Parse(inputs[1].Split(":")[1]);
                int endHour, endMin;
                if (startMin + duraMin >= 60)
                {
                    endHour = startHour + duraHour + 1;
                    endMin = startMin + duraMin - 60;
                }
                else
                {

                    endHour = startHour + duraHour;
                    endMin = startMin + duraMin;
                }

                if (endHour >= 24)
                {
                    int day = endHour / 24;
                    endHour = endHour % 24;
                    Console.WriteLine($"{endHour:D2}:{endMin:D2} +{day}");
                }
                else
                {
                    Console.WriteLine($"{endHour:D2}:{endMin:D2}");
                }
            }
        }
    }
}