using System;

public class Solution {
    public int solution(int[,] dots) {
        int answer = 0;
        int width = Math.Abs(dots[0, 0] - dots[1, 0]);
        int height = Math.Abs(dots[0, 1] - dots[1, 1]);

        if (width == 0)
        {
            width = Math.Abs(dots[0, 0] - dots[2, 0]);
        }

        if (height == 0)
        {
            height = Math.Abs(dots[0, 1] - dots[2, 1]);
        }

        answer = width * height;
        
        return answer;
    }
}
