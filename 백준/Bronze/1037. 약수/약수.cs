namespace _1037
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] inputs = Console.ReadLine().Split(' ');
            List<int> list = new List<int>();

            for (int i = 0; i < inputs.Length; i++)
            {
                list.Add(int.Parse(inputs[i]));
            }

            list.Sort();

            int a = list[0];
            int b = list[list.Count - 1];

            Console.WriteLine(a * b);
        }
    }
}