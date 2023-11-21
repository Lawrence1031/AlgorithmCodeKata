using System;
using System.Linq;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
        string result = "";
        int[] cnt = new int[food.Length - 1];

        // food의 배열에서 food[0]은 물 -> 가장 가운데 위치해야됨
        // 나머지 food[1], food[2], ... / 2 의 값을
        // 작은 인덱스부터 배열, 끝까지 배열 후에 0, 그 이후는 역순으로 배열
        // 위의 food를 기준으로
        // "1223330333221" 을 return하게

        for (int i = 1; i < food.Length; i++)
        {
            cnt[i - 1] = food[i] / 2;
        }

        for (int i = 0; i < cnt.Length; i++)
        {
            for (int j = 0; j < cnt[i]; j++)
            {
                result += (i + 1).ToString();
            }
        }

        string reversedResult = new string(result.Reverse().ToArray());
        answer = result + '0' + reversedResult;
        
        return answer;
    }
}