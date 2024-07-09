namespace _16162
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int A = int.Parse(inputs[1]);
            int D = int.Parse(inputs[2]);

            int[] scales = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int now = A;
            int cnt = 0;

            for (int i = 0; i < scales.Length; i++)
            {
                if (now == scales[i])
                {
                    now += D;
                    cnt++;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}