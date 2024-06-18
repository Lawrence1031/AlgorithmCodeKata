namespace _15784
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int a = int.Parse(inputs[1]);
            int b = int.Parse(inputs[2]);
            List<int> canSee = new List<int>();
            int me = 0;
            for (int i = 0; i < N; i++)
            {
                string[] arrInputs = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    if (i == a - 1 || j == b - 1)
                    {
                        canSee.Add(int.Parse(arrInputs[j]));
                    }

                    if (i == a - 1 && j == b - 1)
                    {
                        me = int.Parse(arrInputs[j]);
                    }
                }
            }

            Console.WriteLine(canSee.Max() == me ? "HAPPY" : "ANGRY");
        }
    }
}