namespace _17284
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int money = 5000;
            foreach (int i in inputs)
            {
                if (i == 1) money -= 500;
                else if (i == 2) money -= 800;
                else money -= 1000;
            }

            Console.WriteLine(money);
        }
    }
}