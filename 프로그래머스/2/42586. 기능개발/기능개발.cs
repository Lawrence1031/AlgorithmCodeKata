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
        List<int> Comp = new List<int>();
        List<int> costTime = new List<int>();

        for (int i = 0; i < progresses.Length; i++)
        {
            int days = (100 - progresses[i] + speeds[i] - 1) / speeds[i];
            Comp.Add(days);
        }

        while (Comp.Count > 0)
        {
            int curDay = Comp[0];
            Comp.RemoveAt(0);
            int cost = 1;

            while (Comp.Count > 0 && Comp[0] <= curDay)
            {
                cost++;
                Comp.RemoveAt(0);
            }

            costTime.Add(cost);
        }

        return costTime.ToArray();
    }
}