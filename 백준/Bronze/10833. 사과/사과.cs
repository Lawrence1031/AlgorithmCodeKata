namespace _10833
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int answer = 0;

            for (int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int students = int.Parse(inputs[0]);
                int apples = int.Parse(inputs[1]);

                answer += apples % students;
            }

            Console.WriteLine(answer);
        }
    }
}