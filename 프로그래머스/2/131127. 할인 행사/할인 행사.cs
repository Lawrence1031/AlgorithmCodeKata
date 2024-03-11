using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] want, int[] number, string[] discount) {
        int answer = 0;
        
        Dictionary<string, int> discountMap = new Dictionary<string, int>();

        for (int i = 0; i <= discount.Length - 10; i++)
        {
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

            int remainItems = 0;
            foreach (int dictValue in discountMap.Values)
            {
                if (dictValue > remainItems)
                {
                    remainItems = dictValue;
                }
            }

            if (remainItems == 0)
            {
                answer++;
            }

            discountMap.Clear();
        }
        
        return answer;
    }
}