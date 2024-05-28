namespace _5612
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int car = int.Parse(Console.ReadLine());
            List<int> amount = new List<int>();
            amount.Add(car);

            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                car += int.Parse(inputs[0]);
                car -= int.Parse(inputs[1]);
                amount.Add(car);
            }

            if (amount.Min() < 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(amount.Max());
            }
        }
    }
}