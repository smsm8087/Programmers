using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        int[] num = new int[10] {0,1,2,3,4,5,6,7,8,9};
        for(int i =0; i<num.Length; ++i)
        {
            bool isContainNum = false;
            for(int j =0; j<numbers.Length; ++j)
            {
                if(num[i] == numbers[j])
                    isContainNum = true;
            }
            if(false == isContainNum)
                answer+=num[i];
        }
        return answer;
    }
}