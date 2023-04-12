using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    for (int k = j+1; k < nums.Length; k++)
                    {
                        int num = nums[i] + nums[j] + nums[k];
                        bool isFlag = false;
                        for (int m = 2; m < num; m++)
                        {
                            if (num % m == 0)
                                isFlag = true;
                        }
                        if(!isFlag)
                            answer++;
                    }
                }
            }
            // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
            System.Console.WriteLine("Hello C#");

            return answer;
    }
}