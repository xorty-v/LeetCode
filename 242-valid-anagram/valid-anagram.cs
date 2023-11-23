public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        if(s == t)
            return true;
        
        if(s.Length != t.Length)
            return false;
        
        var dict = new Dictionary<char, int>();

        foreach(var c in s)
        {
            if(dict.ContainsKey(c))
                dict[c]++;
            else
                dict.Add(c, 1);
        }

        foreach(var c in t)
        {
            if(dict.ContainsKey(c))
                dict[c]--;
            else
                return false;
        }

        if(dict.Values.All(v => v == 0))
            return true;
        else
            return false;
    }
}