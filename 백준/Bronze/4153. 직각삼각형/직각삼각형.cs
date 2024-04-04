namespace _4153
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            while ((s = Console.ReadLine()) != "0 0 0")
            {
                int[] arr = new int[3];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(s.Split(' ')[i]);
                }

                Array.Sort(arr);

                if (arr[0] * arr[0] + arr[1] * arr[1] == arr[2] * arr[2])
                {
                    Console.WriteLine("right");
                }
                else
                {
                    Console.WriteLine("wrong");
                }
            }
        }
    }
}