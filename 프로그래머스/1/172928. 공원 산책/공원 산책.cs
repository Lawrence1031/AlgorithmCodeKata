using System;

public class Solution {
    public int[] solution(string[] park, string[] routes) {
        int H = park.Length;
        int W = park[0].Length;
        int[] point = new int[2];

        for (int i = 0; i < H; i++)
        {
            for (int j = 0; j < W; j++)
            {
                if (park[i][j] == 'S')
                {
                    point[0] = i;
                    point[1] = j;
                    break;
                }
            }
        }

        foreach (var route in routes)
        {
            string[] parts = route.Split(' ');
            string direction = parts[0];
            int distance = int.Parse(parts[1]);

            int dx = 0;
            int dy = 0;

            switch (direction)
            {
                case "N": dx = -1; break;
                case "S": dx = 1; break;
                case "W": dy = -1; break;
                case "E": dy = 1; break;
            }

            bool canMove = true;
            int newX = point[0], newY = point[1];

            for (int step = 0; step < distance; step++)
            {
                newX += dx;
                newY += dy;

                if (newX < 0 || newX >= H || newY < 0 || newY >= W || park[newX][newY] == 'X')
                {
                    canMove = false;
                    break;
                }
            }

            if (canMove)
            {
                point[0] = newX;
                point[1] = newY;
            }
        }
        
        return point;
    }
}