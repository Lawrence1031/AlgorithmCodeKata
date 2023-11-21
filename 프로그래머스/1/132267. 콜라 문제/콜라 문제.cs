using System;

public class Solution {
    public int solution(int a, int b, int n) {
        int answer = 0;
        int cnt = 0;
        int remain = 0;
        int result = 0;

        while (n / a != 0)
        {
            cnt += (n / a) * b;
            remain += n % a;
            n = cnt + remain;
            result += cnt;
            cnt = 0;
            remain = 0;
        }

        answer = result;
        
        return answer;
    }
}