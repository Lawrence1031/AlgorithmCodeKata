using System;

public class Solution {
    public int solution(int order) {
        int answer = 0;
        string orderStr = order.ToString();
        
        for (int i = 0; i < orderStr.Length; i++)
        {
            if (orderStr[i] == '3' || orderStr[i] == '6' || orderStr[i] == '9')
                answer++;
        }
        
        return answer;
    }
}