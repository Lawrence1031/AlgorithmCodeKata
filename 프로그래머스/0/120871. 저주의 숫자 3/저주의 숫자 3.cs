using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int cnt = 0;
        
        // 3의 배수와 숫자 3을 사용하지 않음
        // 369 게임과 비슷한 느낌
        
        for (int i = 1; i <= n + cnt; i++)
        {
            if (i % 3 != 0 && !i.ToString().Contains('3'))
            {
                answer++;
            }
            else
            {
                answer++;
                cnt++;
            }
        }
        
        return answer;
    }
}