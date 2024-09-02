namespace _18311
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            long K = long.Parse(inputs[1]);
            int[] courses = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            long fullcourse = courses.Sum();

            if (K < fullcourse)
            {
                for (int i = 0; i < courses.Length; i++)
                {
                    if (K < courses[i])
                    {
                        Console.WriteLine(i + 1);
                        break;
                    }
                    
                    K -= courses[i];
                }
            }
            else
            {
                K -= fullcourse;
                for (int i = courses.Length - 1; i >= 0; i--)
                {
                    if (K < courses[i])
                    {
                        Console.WriteLine(i + 1);
                        break;
                    }

                    K -= courses[i];
                }
            }
        }
    }
}