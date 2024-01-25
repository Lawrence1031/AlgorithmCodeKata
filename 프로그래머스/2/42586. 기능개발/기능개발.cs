using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        int[] answer = new int[] {};
        
        answer = Develop(progresses, speeds);
        
        return answer;
    }
    
    static public int[] Develop(int[] progresses, int[] speeds)
    {
        Queue<int> queue = new Queue<int>();
        List<int> costTime = new List<int>();

        for (int i = 0; i < progresses.Length; i++)
        {
            int cnt = (100 - progresses[i] + speeds[i] - 1) / speeds[i];

            queue.Enqueue(cnt);
        }

        while (queue.Count > 0)
        {
            int costDay = queue.Dequeue();
            int cnt = 1;

            while (queue.Count > 0 && queue.Peek() <= costDay)
            {
                cnt++;
                queue.Dequeue();
            }

            costTime.Add(cnt);
        }

        return costTime.ToArray();
    }
}