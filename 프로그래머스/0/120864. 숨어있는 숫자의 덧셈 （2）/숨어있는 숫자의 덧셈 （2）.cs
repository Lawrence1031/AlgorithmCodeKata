using System;
using System.Text;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        StringBuilder sb = new StringBuilder();
        
        for (int i = 0; i < my_string.Length; i++)
        {
            if (my_string[i] >= '0' && my_string[i] <= '9')
            {
                sb.Append(my_string[i]);
            }
            else
            {
                if (sb.Length > 0)
                {
                    answer += int.Parse(sb.ToString());
                    sb.Clear();                    
                }
            }
        }
        
        if (sb.Length > 0)
        {
            answer += int.Parse(sb.ToString());
        }
        
        return answer;
    }
}