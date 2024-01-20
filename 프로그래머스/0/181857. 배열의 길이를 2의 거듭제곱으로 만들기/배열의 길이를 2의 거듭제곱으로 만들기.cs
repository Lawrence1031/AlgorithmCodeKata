using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[] {};
        
        List<int> result = arr.ToList();
        
        // arr의 길이가 제곱수인지 판단
        // 제곱수가 아니면 모자란 만큼 0을 추가
        
        if (IsPower(arr.Length))
            answer = arr;
        else
        {        
            while (!IsPower(result.Count))
            {
                result.Add(0);
            }
            
            answer = result.ToArray();
        }
        
        return answer;
    }
    
    static public bool IsPower(int number)
    {
        return (number & (number - 1)) == 0;
    }
}