using System;

public class Solution {
    public int solution(int i, int j, int k) {
        int answer = 0;
        
        k = k + 48;

        for (int x = i; x <= j; x++)
        {
            char[] chr = x.ToString().ToCharArray();

            for (int y = 0; y < chr.Length; y++)
            {
                int num = Convert.ToInt32(chr[y]);
                if (chr[y] == k)
                {
                    answer++;
                }
            }
        }
        
        return answer;
    }
}