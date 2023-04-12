using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
        int[] answer = new int[id_list.Length];
            Dictionary<string, string> mailDic = new Dictionary<string, string>();
            Dictionary<string ,int> reportCountDic = new Dictionary<string, int>();
            List<string> banUserId = new List<string>();
            for (int i = 0; i < id_list.Length; ++i)
            {
                mailDic.Add(id_list[i], "");
                reportCountDic.Add(id_list[i], 0);
            }
            for (int i = 0; i < report.Length; ++i)
            {
                string id = report[i].Split(' ')[0];
                string reportid = report[i].Split(' ')[1];
                if (id == reportid) continue;
                if (!string.IsNullOrEmpty(mailDic[id]))
                {
                    //중복제거
                    string[] ids = mailDic[id].Split('#');
                    bool isSameid = false;
                    for (int j = 0; j < ids.Length; j++)
                    {
                        if(ids[j] == reportid)
                        {
                            isSameid = true;
                        }
                    }
                    if (false == isSameid)
                        mailDic[id] += "#" + reportid;
                }
                else
                    mailDic[id] = reportid;
            }
            foreach (KeyValuePair<string,string> item in mailDic)
            {
                string[] reportIds = item.Value.Split('#');
                for (int i = 0; i < reportIds.Length; i++)
                {
                    if (reportCountDic.ContainsKey(reportIds[i]))
                    {
                        ++reportCountDic[reportIds[i]];
                    }
                }
            }
            foreach (KeyValuePair<string,int> item in reportCountDic)
            {
                if (item.Value >= k)
                    banUserId.Add(item.Key);
            }
            for (int i = 0; i < id_list.Length; ++i)
            {
                string[] reportids = mailDic[id_list[i]].Split('#');
                int count = 0;
                for (int m = 0; m < reportids.Length; m++)
                {
                    for (int j = 0; j < banUserId.Count; ++j)
                    {
                        if (reportids[m] == banUserId[j])
                            ++count;
                    }
                }
                answer[i] = count;
            }

            return answer;
    }
}