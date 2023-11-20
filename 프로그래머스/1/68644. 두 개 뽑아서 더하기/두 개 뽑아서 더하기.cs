using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = new int[] { };
        List<int> newN = new List<int>();
        
        // 정수 배열 numbers에서 2개씩 뽑아서 더해서 만들 수 있는 수를
        // 모두 구해서 result에 넣기
        // result를 오름차순으로 정렬해서 answer에 넣기
        
        // numbers의 두 수를 2개씩 뽑아서 더하기
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                newN.Add(numbers[i] + numbers[j]);
            }
        }
        
        newN.Sort();
        HashSet<int> result = new HashSet<int>(newN);
        answer = result.ToArray();
                
        return answer;
    }
}