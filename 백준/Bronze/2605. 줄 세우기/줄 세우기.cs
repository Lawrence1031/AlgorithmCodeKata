using System;

namespace _2605
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> students = new List<int>();

            string[] inputs = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                int card = int.Parse(inputs[i]);

                students.Insert(students.Count - card, i + 1);
            }

            foreach (int student in students)
            {
                Console.Write(student + " ");
            }
        }
    }
}