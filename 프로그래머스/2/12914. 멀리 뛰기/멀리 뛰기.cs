public class Solution {
    public long solution(int n) {
        long answer = 0;
        
        answer = CountPermutations(n);
        
        return answer;
    }
    
    static int CountPermutations(int n)
    {
        if (n <= 0)
        {
            return 0;
        }
        
        int[] dp = new int[n + 1];
        dp[0] = 1;
        
        for (int i = 1; i <= n; i++)
        {
            if (i - 1 >= 0)
            {
                dp[i] += dp[i - 1] % 1234567;
            }
            if (i - 2 >= 0)
            {
                dp[i] += dp[i - 2] % 1234567;
            }
        }
        
        return dp[n] % 1234567;
    }
}