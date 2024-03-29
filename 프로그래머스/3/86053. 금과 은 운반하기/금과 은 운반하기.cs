using System;

public class Solution {
    public long solution(int a, int b, int[] g, int[] s, int[] w, int[] t) {
        
        long left = 0;
        long right = (long)1e15;
        long answer = right;

        while (left <= right)
        {
            long mid = (left + right) / 2;
            if (Check(mid, a, b, g, s, w, t))
            {
                answer = mid;
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }
        return answer;
    }
    private static bool Check(long time, int a, int b, int[] g, int[] s, int[] w, int[] t)
    {
        long totalGold = 0;
        long totalSilver = 0;
        long total = 0;

        for (int i = 0; i < g.Length; i++)
        {
            long trips = time / (t[i] * 2);
            if (time % (t[i] * 2) >= t[i]) trips++;
            long capacity = trips * w[i];

            long gold = Math.Min(capacity, g[i]);
            totalGold += gold;

            long silver = Math.Min(capacity, s[i]);
            totalSilver += silver;

            total += Math.Min(capacity, g[i] + s[i]);
        }

        return totalGold >= a && totalSilver >= b && total >= a + b;
    }
}