using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;

        answer = Plaindrome(s).Length;

        return answer;
    }
    public static string Plaindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return "";
        }

        int start = 0;
        int end = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int length1 = CenterNum(s, i, i);
            int length2 = CenterNum(s, i, i + 1);
            int length = Math.Max(length1, length2);
            if (length > end - start)
            {
                start = i - (length - 1) / 2;
                end = i + length / 2;                    
            }
        }

        return s.Substring(start, end - start + 1);
    }

    public static int CenterNum(string s, int left, int right)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }
        return right - left - 1;
    }
}