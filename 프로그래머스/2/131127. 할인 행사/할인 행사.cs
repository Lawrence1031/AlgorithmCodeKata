using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] want, int[] number, string[] discount) {
        int answer = 0;
        
        for (int i = 0; i <= discount.Length - 10; i++)
        {
            Dictionary<string, int> discountMap = new Dictionary<string, int>();

            for (int j = 0; j < want.Length; j++)
            {
                discountMap.Add(want[j], number[j]);
            }

            for (int j = i; j < i + 10; j++)
            {
                if (discountMap.ContainsKey(discount[j]))
                {
                    discountMap[discount[j]]--;
                }
            }

            bool allDiscounted = true;
            foreach (var item in discountMap)
            {
                if (item.Value > 0)
                {
                    allDiscounted = false;
                    break;
                }
            }

            if (allDiscounted)
            {
                answer++;
            }
        }
        
        return answer;
    }
}
