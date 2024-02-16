using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] fees, string[] records) {
        int[] answer = new int[] {};
        
        var parkingTime = new Dictionary<string, int>();
        var inTime = new Dictionary<string, string>();

        foreach (var record in records)
        {
            var parts = record.Split(' ');
            var time = parts[0];
            var carNumber = parts[1];
            var check = parts[2];

            if (check == "IN")
            {
                inTime[carNumber] = time;
            }
            else
            {
                var parkedTime = CalculTime(inTime[carNumber], time);
                if (parkingTime.ContainsKey(carNumber))
                {
                    parkingTime[carNumber] += parkedTime;
                }
                else
                {
                    parkingTime[carNumber] = parkedTime;
                }

                inTime.Remove(carNumber);
            }
        }

        foreach (var car in inTime)
        {
            var parkedTime = CalculTime(car.Value, "23:59");
            if (parkingTime.ContainsKey(car.Key))
            {
                parkingTime[car.Key] += parkedTime;
            }
            else
            {
                parkingTime[car.Key] = parkedTime;
            }
        }

        var feesArray = parkingTime.Select(car => new
        {
            CarNumber = car.Key,
            Fee = CalculFee(fees, car.Value)
        })
            .OrderBy(car => car.CarNumber)
            .Select(car => car.Fee)
            .ToArray();

        answer = feesArray;
        
        
        return answer;
    }
    static private int CalculTime(string inTime, string outTime)
    {
        var inParts = inTime.Split(':').Select(int.Parse).ToArray();
        var outParts = outTime.Split(':').Select(int.Parse).ToArray();
        return (outParts[0] * 60 + outParts[1]) - (inParts[0] * 60 + inParts[1]);
    }

    static private int CalculFee(int[] fees, int time)
    {
        if (time <= fees[0])
        {
            return fees[1];
        }
        else
        {
            return fees[1] + (int)Math.Ceiling((double)(time - fees[0]) / fees[2]) * fees[3];
        }
    }
}