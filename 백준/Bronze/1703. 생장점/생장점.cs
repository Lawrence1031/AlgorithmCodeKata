namespace _1703
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] inputs = Console.ReadLine().Split(' ');

                if (inputs[0] == "0")
                {
                    return;
                }

                int age = int.Parse(inputs[0]);
                int[] arr = new int[2 * age];
                int leap = 1;

                for (int i = 0; i < 2 * age; i++)
                {
                    arr[i] = int.Parse(inputs[i + 1]);

                    if (i % 2 == 0)
                    {
                        leap *= arr[i];
                    }
                    else
                    {
                        leap -= arr[i];
                    }
                }

                Console.WriteLine(leap);
            }
        }
    }
}