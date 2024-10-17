namespace _31009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] fares = new int[N];
            int jinjuFare = 0;
            int cnt = 0;

            for (int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                string destination = inputs[0];
                int fare = int.Parse(inputs[1]);

                if (destination == "jinju")
                {
                    Console.WriteLine(fare);
                    jinjuFare = fare;
                }

                fares[i] = fare;
            }

            for (int i = 0; i < N; i++)
            {
                if (fares[i] > jinjuFare) cnt++;
            }

            Console.WriteLine(cnt);
        }
    }
}