public class Solution {
    public int solution(long n) {
        int answer = 0;
        
        long result = 0;
        long curNum = 1;
        long preNum = 0;

        for (int i = 2; i <= n; i++)
        {
            result = (preNum + curNum) % 1234567;
            preNum = curNum % 1234567;
            curNum = result % 1234567;
        }
        
        if (result > 1234567)
            result = result % 1234567;
        
        answer = (int)result;
        
        return answer;
    }
}