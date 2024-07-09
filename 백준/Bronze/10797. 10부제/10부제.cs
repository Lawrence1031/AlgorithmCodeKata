namespace _10797
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] cars = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int cnt = 0;

            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] == n)
                {
                    cnt++;
                }
            }
            
            Console.WriteLine(cnt);
        }
    }
}