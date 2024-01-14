using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        answer = FindPizzaPiece(n) / 6;

        return answer;
    }
    
    static int FindPizza(int a, int b)
    {
        while (b != 0)
        {
            int tmp = b;
            b = a % b;
            a = tmp;
        }
        return a;
    }
    
    static int FindPizzaPiece(int a)
    {
        return (a * 6) / FindPizza(a, 6);
    }
}