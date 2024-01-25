using System;

public class Solution {
    public int solution(int[,] dots) {
        int answer = 0;
        int width = 0;
        int height = 0;

        if (dots[0, 0] - dots[1, 0] != 0)
        {
            width = dots[0, 0] - dots[1, 0];
        }
        else if (dots[0, 0] - dots[2, 0] != 0)
        {
            width = dots[0, 0] - dots[2, 0];
        }

        if (dots[0, 1] - dots[1, 1] != 0)
        {
            height = dots[0, 1] - dots[1, 1];
        }
        else if (dots[0, 1] - dots[2, 1] != 0)
        {
            height = dots[0, 1] - dots[2, 1];
        }

        answer = width * height;
        if (answer < 0)
        {
            answer *= -1;
        }
        
        return answer;
    }
}