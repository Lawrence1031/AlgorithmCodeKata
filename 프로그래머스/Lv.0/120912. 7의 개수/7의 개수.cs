using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            string numString = array[i].ToString();
            for (int j = 0; j < numString.Length; j++)
            {
                if (numString[j] == '7')
                    answer++;
            }
        }
        
        return answer;
    }
}