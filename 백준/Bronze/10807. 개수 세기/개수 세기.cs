namespace _10807
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            string s = Console.ReadLine();
            int v = Convert.ToInt32(Console.ReadLine());

            int answer = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                string[] ss = s.Split(' ');
                arr[i] = Convert.ToInt32(ss[i]);
                if (arr[i] == v)
                {
                    answer++;
                }
            }

            Console.WriteLine(answer);
        }
    }
}