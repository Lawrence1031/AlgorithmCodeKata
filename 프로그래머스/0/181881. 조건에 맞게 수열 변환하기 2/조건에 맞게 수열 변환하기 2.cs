using System;
using System.Linq;

public class Solution {
    public int solution(int[] arr) {
        int answer = 0;
        
        // 50보다 크거나 같은 짝수 -> 나누기 2
        // 50보다 작은 홀수 -> 곱하기 2 + 1
        
        while (true)
        {
            int[] newArr = ConvertArray(arr);
            if (Enumerable.SequenceEqual(arr, newArr))
            {
                break;
            }
            
            arr = newArr;
            answer++;
        }
        
        return answer;
    }
    
    static public int[] ConvertArray(int[] arr)
    {
        int[] newArr = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 50 && arr[i] % 2 == 0)
            {
                newArr[i] = arr[i] / 2;
            }
            else if (arr[i] < 50 && arr[i] % 2 == 1)
            {
                newArr[i] = arr[i] * 2 + 1;
            }
            else
            {
                newArr[i] = arr[i];
            }
        }
        
        return newArr;
    }
}