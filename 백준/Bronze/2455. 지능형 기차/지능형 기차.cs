namespace _2455
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cnt = new int[4];

            for (int i = 0; i < 4; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int download = int.Parse(inputs[0]);
                int upload = int.Parse(inputs[1]);

                if (i == 0)
                {
                    cnt[i] = upload;
                }
                else
                {
                    cnt[i] = cnt[i - 1] - download + upload;
                }
            }

            Console.WriteLine(cnt.Max());
        }
    }
}