namespace _2720
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 25 10 5 1

            int T = int.Parse(Console.ReadLine());
            int[] cent = { 25, 10, 5, 1 };

            for (int i = 0; i < T; i++)
            {
                int[] result = new int[4];
                int money = int.Parse(Console.ReadLine());

                for (int j = 0; j < cent.Length; j++)
                {
                    if (money >= cent[j])
                    {
                        result[j] = money / cent[j];
                        money = money % cent[j];
                    }
                }

                foreach (var item in result)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}