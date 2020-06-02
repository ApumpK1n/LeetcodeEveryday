
using System.Collections.Generic;
public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int MaxNum = 0;
        for(int i=0; i<candies.Length; i++){
            MaxNum = Math.Max(candies[i], MaxNum);
        }

        List<bool> ret = new List<bool>();
        for(int j=0; j<candies.Length; j++){
            ret.Add(candies[j] + extraCandies >= MaxNum);
        }
        return ret;
    }
}