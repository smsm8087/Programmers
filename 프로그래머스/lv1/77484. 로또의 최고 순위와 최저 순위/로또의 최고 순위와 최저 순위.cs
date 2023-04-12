using System;
using System.Collections.Generic;
public class Solution {
    public int getRank(int count)
        {
            int retVal = 0;
            switch (count)
            {
                case 2: retVal = 5; break;
                case 3: retVal = 4; break;
                case 4: retVal = 3; break;
                case 5: retVal = 2; break;
                case 6: retVal = 1; break;
                default: retVal = 6; break;
            }
            return retVal;
        }
    public int[] solution(int[] lottos, int[] win_nums) {
        int count = 0;
            int zerocount = 0;
            List<int> winnumList = new List<int>();
            for (int i = 0; i < win_nums.Length; i++)
            {
                winnumList.Add(win_nums[i]);
            }
            for (int i = 0; i < lottos.Length; i++)
            {
                if (lottos[i] == 0)
                {
                    zerocount++;
                    continue;
                }
                if (winnumList.Contains(lottos[i]))
                {
                    winnumList.Remove(lottos[i]);
                    count++;
                }
            }
            
            int highrank = getRank(count + zerocount);
            int lowrank = getRank(count);
            int[] answer = new int[2] {highrank,lowrank};
            return answer;
    }
}