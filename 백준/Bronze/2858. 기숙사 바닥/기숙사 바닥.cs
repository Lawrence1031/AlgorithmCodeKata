namespace _2858
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int R = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);

            List<int> BList = CheckB(B);

            int a = 0;
            int b = 0;

            for (int i = 0; i < BList.Count; i++)
            {
                b = BList[i];
                a = B / BList[i];
                if (4 + 2 * a + 2 * b == R)
                {
                    break;
                }
            }


            Console.WriteLine($"{a + 2} {b + 2}");
        }

        static List<int> CheckB(int B)
        {
            List<int> result = new List<int>();

            for (int i = 1; i <= B; i++)
            {
                if (B % i == 0)
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}