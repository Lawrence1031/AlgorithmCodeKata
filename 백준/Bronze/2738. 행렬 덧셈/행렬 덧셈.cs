namespace _2738
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split(" ");
            int n = int.Parse(ss[0]);
            int m = int.Parse(ss[1]);
            int[,] arrA = new int[n, m];
            int[,] arrB = new int[n, m];

            int cnt = 0;

            for (int i = 0; i < n; i++)
            {
                string s2 = Console.ReadLine();
                string[] ss2 = s2.Split(" ");
                for (int j = 0; j < ss2.Length; j++)
                {
                    arrA[i, j] = int.Parse(ss2[j]);
                }
            }
            for (int i = 0; i < n; i++)
            {
                string s2 = Console.ReadLine();
                string[] ss2 = s2.Split(" ");
                for (int j = 0; j < ss2.Length; j++)
                {
                    arrB[i, j] = int.Parse(ss2[j]);
                    Console.WriteLine(arrA[i, j] + arrB[i, j]);
                }
            }
        }
    }
}