using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[] {};
        
        int cnt = 0;
        int tmp = 0;
        
        List<int> arrList = new List<int> ();
        
        // 처음 2가 나오는 지점과 마지막으로 2가 나오는 지점을 알면 됨.
        // 2가 1개 나오면 [2]를 return, 2개 0개 나오면 [-1]을 return
        
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 2)
                cnt++;
        }
        
        if (cnt == 0)
        {
            arrList.Add(-1);
        }
        else if (cnt == 1)
        {
            arrList.Add(2);
        }
        else
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 2)
                {
                    tmp++;
                }
                
                if (tmp > 0 && cnt > tmp)
                {
                    arrList.Add(arr[i]);
                }
            }
            
            arrList.Add(2);
        }
        
        answer = arrList.ToArray();
        
        return answer;
    }
}