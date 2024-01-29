using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int x, int y, int n) {
        int answer = Calculate(x, y, n);
        return answer;
    }
    
    static private int Calculate(int x, int y, int n)
    {
        HashSet<int> visited = new HashSet<int>();
        var queue = new Queue<(int value, int steps)>();
        queue.Enqueue((x, 0));

        while (queue.Count > 0)
        {
            var (cur, steps) = queue.Dequeue();

            if (cur == y)
            {
                return steps;
            }

            if (cur > y || visited.Contains(cur))
            {
                continue;
            }

            visited.Add(cur);

            queue.Enqueue((cur + n, steps + 1));
            queue.Enqueue((cur * 2, steps + 1));
            queue.Enqueue((cur * 3, steps + 1));
        }

        return -1;
    }
}