namespace _5575
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] AInputs = Console.ReadLine().Split(' ');
            string[] BInputs = Console.ReadLine().Split(' ');
            string[] CInputs = Console.ReadLine().Split(' ');

            Console.WriteLine(TimeCal(AInputs));
            Console.WriteLine(TimeCal(BInputs));
            Console.WriteLine(TimeCal(CInputs));
        }
        
        static string TimeCal(string[] strings)
        {
            int startTime = int.Parse(strings[0]);
            int startMin = int.Parse(strings[1]);
            int startSec = int.Parse(strings[2]);
            int endTime = int.Parse(strings[3]);
            int endMin = int.Parse(strings[4]);
            int endSec = int.Parse(strings[5]);

            int workTime = endTime - startTime;
            int workMin = endMin - startMin;
            int workSec = endSec - startSec;

            if (workSec < 0)
            {
                workSec += 60;
                workMin--;
            }

            if (workMin < 0)
            {
                workMin += 60;
                workTime--;
            }

            return $"{workTime} {workMin} {workSec}";
        }
    }
}