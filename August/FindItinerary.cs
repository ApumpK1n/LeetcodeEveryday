

// 332. 重新安排行程

/*
给定一个机票的字符串二维数组 [from, to]，子数组中的两个成员分别表示飞机出发和降落的机场地点，对该行程进行重新规划排序。所有这些机票都属于一个从 JFK（肯尼迪国际机场）出发的先生，所以该行程必须从 JFK 开始。

 

提示：

如果存在多种有效的行程，请你按字符自然排序返回最小的行程组合。例如，行程 ["JFK", "LGA"] 与 ["JFK", "LGB"] 相比就更小，排序更靠前
所有的机场都用三个大写字母表示（机场代码）。
假定所有机票至少存在一种合理的行程。
所有的机票必须都用一次 且 只能用一次。
*/

public class Solution {
    public IList<string> FindItinerary(IList<IList<string>> tickets) {
        IList<string> list = new List<string>();
        string from = "JFK";
        list.Add(from);
        int len = tickets.Count + 1;
        int[] pa = new int[len];
        int pos = 0;
        while (list.Count < len)
        {
            IList<IList<string>> curList = tickets.Where(x => x.ElementAt(0) == from).OrderBy(x => x.ElementAt(1)).ToList();
            if (curList.Count== 0 || curList.Count == pa[pos])
            {
                from = list.ElementAt(list.Count-2);
                //tickets 加回去
                IList<string> reback = new List<string>();
                reback.Add(from);
                reback.Add(list.ElementAt(list.Count - 1));
                tickets.Add(reback);
                // list 减掉
                list.RemoveAt(list.Count - 1);

                if (curList.Count == pa[pos])
                {
                    pa[pos] = 0;
                }

                pos--;
                continue;
            }
            from = curList.ElementAt(pa[pos]).ElementAt(1);
            //tickets 减
            tickets.Remove(curList.ElementAt(pa[pos]));
            //list 加
            list.Add(from);
            pa[pos]++;
            pos++;
        }
        return list;
    }
}
