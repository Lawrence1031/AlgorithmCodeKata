using System;

public class Solution {
    public int[] solution(string s) {
        int tryCnt = 0;
        int deleteCnt = 0;
        string sStr = s;
        
        while (sStr != "1")
        {
            string tmp = "";

            for (int i = 0; i < sStr.Length; i++)
            {
                if (sStr[i] == '0')
                    deleteCnt++;
                else
                    tmp += sStr[i];
            }
            tryCnt++;
            sStr = Convert.ToString(tmp.Length, 2);
        }
        
        int[] answer = new int[2] {tryCnt, deleteCnt};
        
        return answer;
    }
}