public class Solution {
    public bool IsSubsequence(string s, string t) 
    {
        int sIndex = 0;

        for(int tIndex = 0; tIndex < t.Length && sIndex < s.Length ; tIndex++)
        {
            if(s[sIndex] == t[tIndex])
                sIndex++;
        }

        return s.Length == sIndex;
    }
}