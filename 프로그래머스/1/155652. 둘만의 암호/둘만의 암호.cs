using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";
                
        char tmp;

        foreach (char c in s)
        {
            tmp = c;
            int cnt = 0;

            while (cnt < index)
            {
                tmp = (char)(tmp + 1);

                if (tmp > 'z')
                    tmp = 'a';

                if (skip.Contains(tmp))
                    continue;

                cnt++;
            }

            answer += tmp;
        }
        
        return answer;
    }
}