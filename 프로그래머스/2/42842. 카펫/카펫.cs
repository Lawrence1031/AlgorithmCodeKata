using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int[] answer = new int[2];
        int w = 0;
        int h = 0;

        for (int i = 1; i <= yellow; i++)
        {
            if (yellow % i == 0)
            {
                w = i;
                h = yellow / i;
                if ((w + 2) * (h + 2) - yellow == brown)
                {                        
                    answer[0] = w + 2;
                    answer[1] = h + 2;
                }
            }
        }
        
        return answer;
    }
}