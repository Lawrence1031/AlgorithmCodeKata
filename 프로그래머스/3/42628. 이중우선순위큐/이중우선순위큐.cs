using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] operations) {
        int[] answer = new int[2];

        List<int> result = new List<int>();

        foreach (string operation in operations)
        {
            string[] parts = operation.Split(' ');

            if (parts[0] == "I")
            {
                int number = int.Parse(parts[1]);
                result.Add(number);
            }
            else
            {
                if (result.Count > 0)
                {
                    if (parts[1] == "1")
                    {
                        int maxValue = result.Max();
                        result.Remove(maxValue);
                    }
                    else
                    {
                        int minValue = result.Min();
                        result.Remove(minValue);
                    }
                }                 
            }
        }

        if (result.Count > 0)
        {
            answer[0] = result.Max();
            answer[1] = result.Min();
        }
        return answer;
    }
}