using System;

public class Solution {
    public int solution(int[] sides) {
        int answer = 0;
        
        if (sides[0] > sides[1])
        {
            for (int i = sides[0] + 1; i < sides[0] + sides[1]; i++)
            {
                answer++;
            }

            for (int i = 1; i <= sides[0]; i++)
            {
                if (i + sides[1] > sides[0])
                {
                    answer++;
                }
            }
        }
        else
        {
            for (int i = sides[1] + 1; i < sides[0] + sides[1]; i++)
            {
                answer++;
            }

            for (int i = 1; i <= sides[1]; i++)
            {
                if (i + sides[0] > sides[1])
                {
                    answer++;
                }
            }
        }
        return answer;
    }
}