public class Solution {
    public int CountCharacters(string[] words, string chars) {
        int result = 0;
        foreach(string word in words){
            int Count = 0 ;
            string tmpChars = chars;
            for(int i=0; i<word.Length; i++){
                string ch = word[i].ToString();
                if (!tmpChars.Contains(ch)) {
                    Count = 0;
                    break;
                }
                else {
                    Count += 1;
                    int j = tmpChars.IndexOf(ch);
                    tmpChars = tmpChars.Remove(j, 1);
                }
            }
            if (Count > 0) result += Count;
        }
        return result;
    }
}
