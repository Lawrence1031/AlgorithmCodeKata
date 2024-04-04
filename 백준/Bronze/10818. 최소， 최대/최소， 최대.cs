namespace _10818
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(s);
            int[] arr = new int[n];
            string s1 = Console.ReadLine();
            string[] ss = s1.Split(' ');

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(ss[i]);
            }

            int min = 1000000;
            int max = -1000000;

            foreach (int i in arr)
            {
                if (i > max)
                {
                    max = i;
                }
                if (i < min)
                {
                    min = i;
                }
            }
            Console.WriteLine(min + " " + max);
        }
    }
}