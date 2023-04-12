using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];
            for (int i = 0; i < commands.GetLength(0); i++)
            {
                List<int> arrayList = array.ToList();

                int beginCutindex = commands[i, 0];
                int endCutindex = commands[i, 1];
                int sortnum = commands[i, 2];

                List<int> newList = new List<int>();
                for (int j = beginCutindex - 1; j <= endCutindex-1; j++)
                {
                    newList.Add(arrayList[j]);
                }
                newList.Sort();
                if(newList.Count!=0 && newList.Count>=sortnum-1)
                    answer[i] = newList[sortnum-1];
            }
            return answer;
    }
}