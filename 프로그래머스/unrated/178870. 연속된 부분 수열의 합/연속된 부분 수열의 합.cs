using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] sequence, int k)
        {
            int[] answer = new int[2];

                int left = 0;
                int right = 0;
                int curSum = sequence[0];
                int minLength = int.MaxValue;

                while (left < sequence.Length)
                {
                    if(curSum < k)
                    {
                        ++right;
                        if (right >= sequence.Length) break;
                        curSum += sequence[right];
                    }
                    else if( curSum == k)
                    {
                        if(minLength > right - left)
                        {
                            minLength = right - left;
                            answer[0] = left;
                            answer[1] = right;
                        }
                        curSum -= sequence[left];
                        ++left;
                    }
                    else
                    {
                        curSum -= sequence[left];
                        ++left;
                    }
                }
                return answer;
        }
}