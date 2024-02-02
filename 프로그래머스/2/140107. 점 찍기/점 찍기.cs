using System;

public class Solution {
    public long solution(int k, int d) {
        long answer = 0;
        long dd = (long)d * (long)d;

        for (int i = 0; i <= d; i += k)
        {
            long ii = (long)i * (long)i;
            long yy = (long)(dd - ii);
            int y = (int)Math.Sqrt(yy);
            answer += (y / k) + 1;
        }
        
        return answer;
    }
}
