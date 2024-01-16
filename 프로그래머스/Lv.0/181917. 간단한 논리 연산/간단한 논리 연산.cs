using System;

public class Solution {
    public bool solution(bool x1, bool x2, bool x3, bool x4) {
        bool answer = false;
        bool left = true;
        bool right = true;
        
        // ∨ 는 1개라도 참이면 참
        // ∧ 는 1개라도 거짓이면 거짓
        
        // (x1 ∨ x2) ∧ (x3 ∨ x4) 에서
        // x1과 x2 중 하나라도 참이면 왼쪽은 참
        // x3과 x4 중 하나라도 참이면 오른쪽은 참
        // 왼쪽과 오른쪽 모두 참이면 참
        
        if (x1 == false && x2 == false)
            left = false;
        
        if (x3 == false && x4 == false)
            right = false;
        
        if (left != false && right != false)
            answer = true;
        
        return answer;
    }
}