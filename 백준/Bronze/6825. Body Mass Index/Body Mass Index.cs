namespace _6825
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double BMI = weight / (height * height);

            if (BMI > 25)
            {
                Console.WriteLine("Overweight");
            }
            else if (BMI >= 18.5 && BMI <= 25.0)
            {
                Console.WriteLine("Normal weight");
            }
            else
            {
                Console.WriteLine("Underweight");
            }
        }
    }
}