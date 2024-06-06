namespace _2909
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int C = int.Parse(inputs[0]);
            int K = int.Parse(inputs[1]);
            int money = (int)Math.Pow(10, K);

            int answer = ((C + (money / 2)) / money) * money;
            Console.WriteLine(answer);
        }
    }
}