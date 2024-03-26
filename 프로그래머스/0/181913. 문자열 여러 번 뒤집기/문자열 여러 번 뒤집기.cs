using System;
using System.Text;

public class Solution {
    public string solution(string my_string, int[,] queries) {
        StringBuilder sb = new StringBuilder(my_string);

        for (int i = 0; i < queries.GetLength(0); i++)
        {
            int start = queries[i, 0];
            int end = queries[i, 1];
            ReverseSubstring(sb, start, end);
        }
        
        return sb.ToString();
    }
    
    private static void ReverseSubstring(StringBuilder sb, int start, int end)
    {
        while (start < end)
        {
            char tmp = sb[start];
            sb[start] = sb[end];
            sb[end] = tmp;
            start++;
            end--;
        }
    }
}