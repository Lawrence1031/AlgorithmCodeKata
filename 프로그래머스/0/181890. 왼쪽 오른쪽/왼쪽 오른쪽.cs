using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string[] solution(string[] str_list) {
        string[] answer = new string[] {};
        
        int check = 0;
        int index = 0;
        List<string> result = new List<string> ();
        
        for (int i = 0; i < str_list.Length; i++)
        {
            if (str_list[i] == "l")
            {
                check = -1;
                index = i;
                break;
            }
            else if (str_list[i] == "r")
            {
                check = 1;
                index = i;
                break;
            }
        }
        
        if (check == -1)
        {
            result.AddRange(str_list.Take(index));
        }
        else if (check == 1)
        {
            result.AddRange(str_list.Skip(index + 1).Take(str_list.Length - index + 1));
        }
        
        answer = result.ToArray();
        
        return answer;
    }
}