using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[,] jobs) {
        int answer = 0;
        
        List<(int requestTime, int requireTime)> jobList = new List<(int, int)>();
        for (int i = 0; i < jobs.GetLength(0); i++)
        {
            jobList.Add((jobs[i, 0], jobs[i, 1]));
        }

        jobList.Sort((a, b) => a.requestTime.CompareTo(b.requestTime));


        int currentTime = 0;
        int totalWaitTime = 0;
        int jobsCompleted = 0;

        List<(int requestTime, int requireTime)> queue = new List<(int, int)>();

        while (jobsCompleted < jobs.GetLength(0))
        {
            foreach (var job in jobList.ToList())
            {
                if (job.requestTime <= currentTime)
                {
                    queue.Add(job);
                    jobList.Remove(job);
                }
            }

            if (queue.Count > 0)
            {
                queue.Sort((a, b) => a.requireTime.CompareTo(b.requireTime));

                var (requestTime, requireTime) = queue[0];
                queue.RemoveAt(0);

                currentTime += requireTime;
                totalWaitTime += currentTime - requestTime;
                jobsCompleted++;
            }
            else
            {
                if (jobList.Any())
                {
                    currentTime = jobList.Min(job => job.requestTime);
                }
            }
        }

        answer = totalWaitTime / jobs.GetLength(0);
        return answer;
    }
}