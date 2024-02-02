using System;

public class Solution {
    public long solution(int k, int d) {
        long answer = 0;

        for (int i = 0; i <= d; i += k)
        {
            long ii = (long)i * (long)i;
            long yy = (long)((long)d * (long)d - ii);
            int y = (int)Math.Sqrt(yy);
            answer += (y / k) + 1;

        }
        
        return answer;
    }
}