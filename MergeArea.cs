//给出一个区间的集合，请合并所有重叠的区间。


public class Solution {
     public int[][] Merge(int[][] intervals)
        {
             List<int[]> list = new List<int[]>();
            int[][] res0 = list.ToArray();
            if (intervals.Length == 0) return res0;
            if (intervals.Length == 1) return intervals;
            TestCompare2 test = new TestCompare2();
            Array.Sort(intervals, test);
            
            int front = intervals[0][0];
            int temp = intervals[0][1];

            for (int i = 0;i < intervals.Length-1; i++)
            {
                
                if (temp >= intervals[i + 1][0])
                {
                    if(i == intervals.Length - 2)
                    {
                        list.Add(new int[] { front, Math.Max(temp, intervals[i + 1][1]) });
                    }
                    temp = Math.Max(temp, intervals[i + 1][1]);
                }
                else
                {
                    list.Add(new int[] { front, temp });
                    front = intervals[i + 1][0];
                    temp = intervals[i + 1][1];
                    if (i == intervals.Length - 2)
                    {
                        list.Add(new int[] { intervals[i + 1][0], intervals[i + 1][1] });
                    }
                }
            }
            int[][] res = list.ToArray();
            return res;
        }
}
class TestCompare2 : IComparer<int[]>
    {
        public int Compare(int[] x, int[] y)
        {
            return x[0].CompareTo(y[0]);
        }
    }