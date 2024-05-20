namespace _1551
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int K = int.Parse(inputs[1]);
            List<int> firstList = new List<int>();

            string[] arrayInputs = Console.ReadLine().Split(',');
            for (int i = 0; i < arrayInputs.Length; i++)
            {
                firstList.Add(int.Parse(arrayInputs[i]));
            }

            List<int> changeList = firstList;

            for (int i = 0; i < K; i++)
            {
                changeList = ChangeList(changeList);
            }

            string answer = string.Join(",", changeList);
            Console.WriteLine(answer);
        }

        static List<int> ChangeList(List<int> inputList)
        {
            List<int> result = new List<int>();
            for (int i = 1; i < inputList.Count; i++)
            {
                result.Add(inputList[i] - inputList[i - 1]);
            }

            return result;
        }
    }
}