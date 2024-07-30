namespace _30794
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int level = int.Parse(inputs[0]);
            string condition = inputs[1];
            int score = 0;

            if (condition == "bad")
            {
                score = level * 200;
            }
            else if (condition == "cool")
            {
                score = level * 400;
            }
            else if (condition == "great")
            {
                score = level * 600;
            }
            else if (condition == "perfect")
            {
                score = level * 1000;
            }

            Console.WriteLine(score);
        }
    }
}