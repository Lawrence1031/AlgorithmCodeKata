using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers, string direction) {
        int[] answer = new int[] {};
        
        List<int> numList = numbers.ToList();
        
        if (direction == "left")
        {
            numList.Add(numList[0]);
            numList.RemoveRange(0, 1);            
        }
        else
        {
            numList.Insert(0, numList[numList.Count - 1]);
            numList.RemoveAt(numList.Count - 1);
        }
        
        answer = numList.ToArray();
        
        return answer;
    }
}