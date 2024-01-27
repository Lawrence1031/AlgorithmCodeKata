using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string numbers) {
        int answer = 0;
        var results = GenerateComb(numbers);

        foreach (var num in results)
        {
            if (IsPrime(num))
                answer++;
        }
        
        return answer;
    }
    
    static private bool IsPrime(int n)
    {
        if (n <= 1)
            return false;
        if (n == 2)
            return true;
        if (n % 2 == 0)
            return false;

        int sqrt = (int)Math.Floor(Math.Sqrt(n));

        for (int i = 3; i <= sqrt; i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    private static HashSet<int> GenerateComb(string numbers)
    {
        var results = new HashSet<int>();
        var queue = new Queue<(string current, string remaining)>();

        queue.Enqueue((current: "", remaining: numbers));

        while (queue.Count > 0)
        {
            var (current, remaining) = queue.Dequeue();

            if (!string.IsNullOrEmpty(current))
            {
                results.Add(Convert.ToInt32(current));
            }

            for (int i = 0; i < remaining.Length; i++)
            {
                queue.Enqueue((current + remaining[i], remaining.Substring(0, i) + remaining.Substring(i + 1)));
            }
        }

        return results;
    }
}