using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] priorities, int location) {
        int answer = 0;
        
        var queue = new Queue<(int Priority, int Index)>();
        for (int i = 0; i < priorities.Length; i++)
        {
            queue.Enqueue((priorities[i], i));
        }

        int order = 0;
        while (queue.Any())
        {
            var current = queue.Dequeue();
            if (queue.Any(q => q.Priority > current.Priority))
            {
                queue.Enqueue(current);
            }
            else
            {
                order++;
                if (current.Index == location)
                {
                    break;
                }
            }
        }

        answer = order;
        return answer;
    }
}