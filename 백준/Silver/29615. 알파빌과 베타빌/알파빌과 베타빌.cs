namespace _29615
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] friends = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] firstArr = new int[M];
            Array.Copy(arr, firstArr, M);
            Array.Sort(friends);

            int cnt = 0;
            for (int i = 0; i < friends.Length; i++)
            {
                if (!firstArr.Contains(friends[i]))
                {
                    cnt++;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}