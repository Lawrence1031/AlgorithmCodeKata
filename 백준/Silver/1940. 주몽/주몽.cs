namespace _1940
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int[] materials = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Array.Sort(materials);

            int left = 0;
            int right = N - 1;
            int cnt = 0;

            while (left < right)
            {
                int sum = materials[left] + materials[right];

                if (sum == M)
                {
                    cnt++;
                    left++;
                    right--;
                }
                else if (sum < M)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}