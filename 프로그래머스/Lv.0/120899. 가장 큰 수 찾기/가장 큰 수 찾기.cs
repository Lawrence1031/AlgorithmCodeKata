using System;

public class Solution {
    public int[] solution(int[] array) {
        int[] answer = new int[2];
        int tmp = 0;
        int tmpIndex = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > tmp)
            {
                tmp = array[i];
                tmpIndex = i;
            }
        }
        
        answer[0] = tmp;
        answer[1] = tmpIndex;
        
        return answer;
    }
}