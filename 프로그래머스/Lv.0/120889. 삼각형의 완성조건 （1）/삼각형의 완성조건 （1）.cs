using System;

public class Solution {
    public int solution(int[] sides) {
        int answer = 2;
        
        // sides에 있는 세 수 중 가장 큰 수를 a로
        // 나머지 두 수를 b, c로 했을 때,
        // a < b + c 가 되면 1, 아니면 2를 return
        
        Array.Sort(sides);
        
        if (sides[2] < sides[0] + sides[1])
            answer = 1;
        
        return answer;
    }
}