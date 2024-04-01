using System;
using System.Collections.Generic;

public class Solution {
    Dictionary<string, string> alpNum = new Dictionary<string, string>
    {
        {"zero", "0"}, {"one", "1"}, {"two", "2"},
        {"three", "3"}, {"four", "4"}, {"five", "5"},
        {"six", "6"}, {"seven", "7"}, {"eight", "8"}, {"nine", "9"}
    };
    
    public long solution(string numbers) {
        long answer = 0;
        
        foreach (var pair in alpNum)
        {
            numbers = numbers.Replace(pair.Key, pair.Value);
        }
        
        answer = long.Parse(numbers);
        
        return answer;
    }
}