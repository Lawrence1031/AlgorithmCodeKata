using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        for (int i = 1; i <= 10; i++)
        {
            if (Factorial(i) <= n)
                answer = i;
            else
                break;
        }
        
        return answer;
    }
    
    static int Factorial(int num)
    {
        int tmp = 1;
        for (int i = num; i > 1; i--)
        {
            tmp *= i;
        }
        
        return tmp;
    }
}