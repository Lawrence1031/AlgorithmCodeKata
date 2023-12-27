using System;

public class Solution {
    public int solution(int price) {
        int answer = 0;
        float result = 0f;
        
        if (price >= 500000)
            result = 0.8f * price;
        else if (price >= 300000 && price < 500000)
            result = 0.9f * price;
        else if (price >= 100000 && price < 300000)
            result = 0.95f * price;
        else
            result = price;
        
        answer = (int)Math.Truncate(result);
        
        return answer;
    }
}