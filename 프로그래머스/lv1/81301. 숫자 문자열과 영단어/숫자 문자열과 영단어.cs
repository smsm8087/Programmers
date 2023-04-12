using System;

public class Solution {
    public int solution(string s) {
        if (s.Contains("zero"))
                s=s.Replace("zero", "0");
            if (s.Contains("one"))
                s = s.Replace("one", "1");
            if (s.Contains("two"))
                s = s.Replace("two", "2");
            if (s.Contains("three"))
                s = s.Replace("three", "3");
            if (s.Contains("four"))
                s = s.Replace("four", "4");
            if (s.Contains("five"))
                s = s.Replace("five", "5");
            if (s.Contains("six"))
                s = s.Replace("six", "6");
            if (s.Contains("seven"))
                s = s.Replace("seven", "7");
            if (s.Contains("eight"))
                s = s.Replace("eight", "8");
            if (s.Contains("nine"))
                s = s.Replace("nine", "9");
            int.TryParse(s, out int answer);
            return answer;
    }
}