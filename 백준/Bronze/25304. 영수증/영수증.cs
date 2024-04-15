namespace _25304
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            int addUp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                arr[i] = int.Parse(inputs[0]) * int.Parse(inputs[1]);
                addUp += arr[i];
            }

            if (X == addUp)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}