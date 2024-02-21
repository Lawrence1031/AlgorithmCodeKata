using System;

public class Solution {
    public long solution(int r1, int r2) {
        
        long answer = r2 - r1 + 1;
        long r1Sqaure = (long)Math.Pow(r1, 2);
        long r2Sqaure = (long)Math.Pow(r2, 2);

        for (int x = 1; x <= r2; x++)
        {
            long xSquare = (long)Math.Pow(x, 2);
            int yMax = (int)Math.Sqrt(r2Sqaure - xSquare);

            if (x < r1)
            {
                int yMin = (int)Math.Ceiling(Math.Sqrt(r1Sqaure - xSquare));
                answer += yMax - yMin + 1;
            }
            else
            {
                answer += yMax;
            }
        }

        answer *= 4;
        
        return answer;
    }
}