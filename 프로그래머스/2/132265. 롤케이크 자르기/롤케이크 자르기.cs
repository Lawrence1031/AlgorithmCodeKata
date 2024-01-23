using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] topping) {
        int answer = 0;
        
        Dictionary<int, int> totalTops = new Dictionary<int, int>();
        Dictionary<int, int> currentTops = new Dictionary<int, int>();
        int totalToppings = 0; 
        int CurToppings = 0;

        foreach (int t in topping)
        {
            if (!totalTops.ContainsKey(t))
            {
                totalTops[t] = 0;
                totalToppings++;
            }
            totalTops[t]++;
        }

        for (int i = 0; i < topping.Length - 1; i++)
        {
            int t = topping[i];
            if (!currentTops.ContainsKey(t))
            {
                currentTops[t] = 0;
                CurToppings++;
            }
            currentTops[t]++;
            totalTops[t]--;

            if (totalTops[t] == 0)
            {
                totalToppings--;
            }

            if (totalToppings == CurToppings)
            {
                answer++;
            }
        }
        
        return answer;
    }
}