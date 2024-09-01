namespace _25285
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                double height = double.Parse(inputs[0]);
                double weight = double.Parse(inputs[1]);
                double BMI = weight / ((height / 100.0) * (height / 100.0));

                if (height < 140.1)
                {
                    Console.WriteLine(6);
                }
                else if (height >= 140.1 && height < 146)
                {
                    Console.WriteLine(5);
                }
                else if (height >= 146 && height < 159)
                {
                    Console.WriteLine(4);
                }
                else if (height >= 159 && height < 161)
                {
                    if (BMI >= 16.0 && BMI < 35.0)
                    {
                        Console.WriteLine(3);
                    }
                    else
                    {
                        Console.WriteLine(4);
                    }
                }
                else if (height >= 161 && height < 204)
                {
                    if (BMI >= 20.0 && BMI < 25.0)
                    {
                        Console.WriteLine(1);
                    }
                    else if ((BMI >= 18.5 && BMI < 20) || (BMI >= 25.0 && BMI < 30))
                    {
                        Console.WriteLine(2);
                    }
                    else if ((BMI >= 16.0 && BMI < 18.5) || (BMI >= 30.0 && BMI < 35.0))
                    {
                        Console.WriteLine(3);
                    }
                    else
                    {
                        Console.WriteLine(4);
                    }
                }
                else
                {
                    Console.WriteLine(4);
                }
            }
        }
    }
}