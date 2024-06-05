namespace _10372
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int segments = int.Parse(Console.ReadLine());

            int[] segmentCnt = { 6, 2, 5, 5, 4, 5, 6, 3, 7, 6 };

            for (int hh = 0; hh < 24; hh++)
            {
                for (int mm = 0; mm < 60; mm++)
                {
                    int totalSegments = 0;

                    totalSegments += segmentCnt[hh / 10];
                    totalSegments += segmentCnt[hh % 10];
                    totalSegments += segmentCnt[mm / 10];
                    totalSegments += segmentCnt[mm % 10];

                    if (totalSegments == segments)
                    {
                        Console.WriteLine($"{hh:D2}:{mm:D2}");
                        return;
                    }
                }
            }

            Console.WriteLine("Impossible");
        }
    }
}