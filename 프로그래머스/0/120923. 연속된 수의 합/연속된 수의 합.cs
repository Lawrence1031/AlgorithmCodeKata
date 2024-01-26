using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int num, int total) {
        int[] answer = new int[] {};
        List<int> list = new List<int>();

        if (num % 2 == 1)
        {
            int tmp = total / num;
            int cnt = num - 1;

            list.Add(tmp);

            for (int i = 1; i <= cnt / 2; i++)
            {
                list.Add(tmp - i);
                list.Add(tmp + i);
            }
        }
        else
        {
            int tmp = total / num;
            int cnt = num;

            list.Add(tmp);
            list.Add(tmp + (cnt / 2));

            for (int i = 1; i < cnt/ 2; i++)
            {
                list.Add(tmp - i);
                list.Add(tmp + i);
            }
        }

        list.Sort();

        answer = list.ToArray();

        list.Sort();
        answer = list.ToArray();
        
        return answer;
    }
}