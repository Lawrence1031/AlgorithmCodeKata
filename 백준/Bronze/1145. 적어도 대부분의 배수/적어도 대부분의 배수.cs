namespace _1145
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int[] arr = new int[5];

            for (int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(inputs[i]);
            }
            int startNum = arr.Min();

            while (true)
            {
                int cnt = 0;

                for (int i = 0; i < arr.Length ; i++)
                {
                    if (startNum % arr[i] == 0)
                    {
                        cnt++;
                    }
                }

                if (cnt >= 3)
                {
                    Console.WriteLine(startNum);
                    return;
                }

                startNum++;
            }
        }
    }
}