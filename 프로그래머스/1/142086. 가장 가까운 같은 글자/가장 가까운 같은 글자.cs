using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        int[] FirstApp = new int[256];
        
        // 문자열 s. 처음 나오는 글자는 -1
        for (int i = 0; i < FirstApp.Length; i++)
        {
            FirstApp[i] = -1;
        }
        
        // 두번째 이후에 나오는 글자에 대해서
        // 같은 글자가 몇 글자 앞에 나왔는지
        for (int i = 0; i < s.Length; i++)
        {
            char currentChar = s[i];
            int preIdx = FirstApp[currentChar];
            FirstApp[currentChar] = i;

            // 거리 계산 및 출력
            if (preIdx == -1)
            {
                answer[i] = -1;
            }
            else
            {
                answer[i] = i - preIdx;
            }
        }
        
        return answer;
    }
}