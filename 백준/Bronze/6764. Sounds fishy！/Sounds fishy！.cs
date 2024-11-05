namespace _6764
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] depth = new int[4];
            for (int i = 0; i < 4; i++)
            {
                depth[i] = int.Parse(Console.ReadLine());
            }

            if (depth[0] == depth[1] && depth[1] == depth[2] && depth[2] == depth[3])
            {
                Console.WriteLine("Fish At Constant Depth");
            }
            else if (depth[0] < depth[1] && depth[1] < depth[2] && depth[2] < depth[3])
            {
                Console.WriteLine("Fish Rising");
            }
            else if (depth[0] > depth[1] && depth[1] > depth[2] && depth[2] > depth[3])
            {
                Console.WriteLine("Fish Diving");
            }
            else
            {
                Console.WriteLine("No Fish");
            }
        }
    }
}