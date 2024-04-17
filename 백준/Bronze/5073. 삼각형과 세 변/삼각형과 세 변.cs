namespace _5073
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int[] arr = new int[3];

                for (int i = 0; i < 3; i++)
                {
                    arr[i] = int.Parse(inputs[i]);
                }

                Array.Sort(arr);

                if (arr[0] == 0) return;

                if (arr[2] >= arr[0] + arr[1])
                {
                    Console.WriteLine("Invalid");
                }
                else
                {
                    if (arr[0] == arr[1] && arr[1] == arr[2])
                    {
                        Console.WriteLine("Equilateral");
                    }
                    else if (arr[0] == arr[1] || arr[1] == arr[2] || arr[2] == arr[0])
                    {
                        Console.WriteLine("Isosceles");
                    }
                    else
                    {
                        Console.WriteLine("Scalene");
                    }
                }
            }
        }
    }
}