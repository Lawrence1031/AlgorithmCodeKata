namespace _1244
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] switches = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int studentNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < studentNumber; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int type = int.Parse(inputs[0]);
                int number = int.Parse(inputs[1]);
                if (type == 1)
                {
                    for (int j = 1; j * number <= n; j++)
                    {
                        ChangeSwitch(switches, j * number - 1);
                    }
                }
                else
                {
                    ChangeSwitch(switches, number - 1);

                    for (int j = 1; number - 1 + j < n && number - 1 - j >= 0; j++)
                    {
                        if (switches[number - 1 + j] == switches[number - 1 - j])
                        {
                            ChangeSwitch(switches, number - 1 + j);
                            ChangeSwitch(switches, number - 1 - j);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i < switches.Length; i++)
            {
                Console.Write(switches[i] + " ");
                if ((i + 1) % 20 == 0)
                {
                    Console.WriteLine();
                }
            }
        }

        static void ChangeSwitch(int[] arr, int i)
        {
            arr[i] = arr[i] == 0 ? 1 : 0;
        }
    }
}