namespace _10814
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] arr = new string[N];

            var list = new List<Tuple<int, string>>();

            for (int i = 0; i < N; i++)
            {
                arr[i] = Console.ReadLine();
                int age = int.Parse(arr[i].Split(' ')[0]);
                string name = arr[i].Split(' ')[1];

                list.Add(Tuple.Create(age, name));
            }

            list = list.OrderBy(x => x.Item1).ToList();

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Item1} {item.Item2}");
            }
        }
    }
}