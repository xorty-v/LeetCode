public class Solution {
    public bool IsSubsequence(string s, string t) 
    {
        int sIndex = 0;
        int tIndex = 0;

        while(sIndex < s.Length && tIndex < t.Length)
        {
            if (s[sIndex] == t[tIndex])
                sIndex++;

            tIndex++;
        }

        return s.Length == sIndex;
    }
}