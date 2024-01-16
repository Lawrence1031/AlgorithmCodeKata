using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int[] slicer, int[] num_list) {
        int[] answer = new int[] {};
        
        if (n == 1)
        {
            answer = num_list.Take(slicer[1] + 1).ToArray();
        }
        else if (n == 2)
        {
            answer = num_list.Skip(slicer[0]).ToArray();
        }
        else if (n == 3)
        {
            answer = num_list.Skip(slicer[0]).Take(slicer[1] - slicer[0] + 1).ToArray();
        }
        else
        {
            answer = num_list.Skip(slicer[0])
                             .Take(slicer[1] - slicer[0] + 1)
                             .Where((item, index) => index % slicer[2] == 0)
                             .ToArray();
        }
              
        
        return answer;
    }
}