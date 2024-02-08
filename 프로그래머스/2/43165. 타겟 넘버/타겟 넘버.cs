using System;

public class Solution {
    public int solution(int[] numbers, int target) {
        int answer = 0;
        answer = FindTarget(numbers, target);
        
        return answer;
    }
    static public int FindTarget(int[] numbers, int target)
    {
        return DFS(numbers, 0, 0, target);
    }

    static private int DFS(int[] numbers, int index, int sum, int target)
    {
        if (index == numbers.Length)
        {
            if (sum == target)
            {
                return 1;
            }
            return 0;
        }

        int add = DFS(numbers, index + 1, sum + numbers[index], target);
        int subtract = DFS(numbers, index + 1, sum - numbers[index], target);

        return add + subtract;
    }
}