namespace _21312
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int maxCocktail = 0;

            for (int i = 1; i < (1 << inputs.Length); i++)
            {
                int cocktail = 1;
                for (int j = 0; j < inputs.Length; j++)
                {
                    if ((i & (1 << j)) != 0)
                    {
                        cocktail *= inputs[j];
                    }
                }

                if (cocktail % 2 != 0)
                {
                    maxCocktail = Math.Max(maxCocktail, cocktail);
                }
            }

            if (maxCocktail == 0)
            {
                maxCocktail = inputs.Aggregate(1, (x, y) => x * y);
            }

            Console.WriteLine(maxCocktail);
        }
    }
}