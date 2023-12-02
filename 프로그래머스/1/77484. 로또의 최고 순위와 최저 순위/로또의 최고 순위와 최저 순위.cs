using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2];
        int cnt = 0;
        int match = 0;

        for (int i = 0; i < lottos.Length; i++)
        {
            if (lottos[i] == 0)
            {
                cnt++;
            }
            else
            {
                for (int j = 0; j < win_nums.Length; j++)
                {
                    if (lottos[i] == win_nums[j])
                        match++;
                }
            }
        }

        answer[0] = cnt + match;
        answer[1] = match;

        for (int i = 0; i < answer.Length; i++)
        {
            if (answer[i] == 6)
                answer[i] = 1;
            else if (answer[i] == 5)
                answer[i] = 2;
            else if (answer[i] == 4)
                answer[i] = 3;
            else if (answer[i] == 3)
                answer[i] = 4;
            else if (answer[i] == 2)
                answer[i] = 5;
            else
                answer[i] = 6;
        }
        
        
        
        
        
        return answer;
    }
}