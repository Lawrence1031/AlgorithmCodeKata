namespace _10871
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            int n = int.Parse(ss[0]);
            int x = int.Parse(ss[1]);

            string s2 = Console.ReadLine();
            string[] ss2 = s2.Split(' ');
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(ss2[i]);
                if (arr[i] < x)
                {
                    Console.Write(arr[i] + " ");
                }
            }

        }
    }
}