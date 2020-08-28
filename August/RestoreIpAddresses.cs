

// 93. 复原IP地址


/*
给定一个只包含数字的字符串，复原它并返回所有可能的 IP 地址格式。

有效的 IP 地址 正好由四个整数（每个整数位于 0 到 255 之间组成，且不能含有前导 0），整数之间用 '.' 分隔。

例如："0.1.2.201" 和 "192.168.1.1" 是 有效的 IP 地址，但是 "0.011.255.245"、"192.168.1.312" 和 "192.168@1.1" 是 无效的 IP 地址。
*/

public class Solution {

    int SEG_COUNT = 4;
    int[] segments = null;
    IList<string> ans = new List<string>();

    public IList<string> RestoreIpAddresses(string s) {
        segments = new int[SEG_COUNT];
        dfs(s, 0, 0);
        return ans;
    }

    void dfs(string s, int segId,int segStart)
    {
        if(segId == SEG_COUNT)
        {
            if (segStart == s.Length)
            {
                StringBuilder ipAddr = new StringBuilder();
                for (int i = 0; i < SEG_COUNT; i++)
                {
                    ipAddr.Append(segments[i]);
                    if (i != SEG_COUNT - 1)
                    {
                        ipAddr.Append(".");
                    }
                }
                ans.Add(ipAddr.ToString());
            }
            return;
        }

        if(segStart == s.Length)
        {
            return;
        }

        if (s.Substring(segStart, 1) == "0")
        {
            segments[segId] = 0;
            dfs(s, segId + 1, segStart + 1);
        }

        int addr = 0;
        for (int segEnd = segStart; segEnd < s.Length; segEnd++)
        {
            addr = int.Parse(s.Substring(segStart, segEnd - segStart + 1));
            if(addr > 0 && addr <= 255)
            {
                segments[segId] = addr;
                dfs(s, segId + 1, segEnd + 1);
            }
            else
            {
                break;
            }
        }
    }
}