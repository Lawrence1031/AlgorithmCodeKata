namespace _2566
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[9, 9];
            int maxValue = -1;
            int x = 0;
            int y = 0;

            for (int i = 0; i < 9; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                for (int j = 0; j < 9; j++)
                {
                    arr[i, j] = Convert.ToInt32(inputs[j]);

                    if (arr[i, j] > maxValue)
                    {
                        maxValue = arr[i, j];
                        x = i + 1;
                        y = j + 1;
                    }
                }
            }

            Console.WriteLine(maxValue);
            Console.WriteLine(x + " " + y);
        }
    }
}