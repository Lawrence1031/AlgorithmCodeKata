using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string my_string, int[] indices) {
        
        List<char> strList = my_string.ToCharArray().ToList();
        
        indices = indices.OrderByDescending(x => x).ToArray();
        
        for (int i = 0; i < indices.Length; i++)
        {
            strList.RemoveAt(indices[i]);
        }
        
        string answer = new string(strList.ToArray());
        
        return answer;
    }
}