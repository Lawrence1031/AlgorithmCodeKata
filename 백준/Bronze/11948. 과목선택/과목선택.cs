namespace _11948
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] class4 = new int[4];
            int[] class2 = new int[2];

            for (int i = 0; i < 4; i++)
            {
                class4[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 2; i++)
            {
                class2[i] = int.Parse(Console.ReadLine());
            }

            int answer = class4.Sum() - class4.Min() + class2.Max();
            Console.WriteLine(answer);
        }
    }
}