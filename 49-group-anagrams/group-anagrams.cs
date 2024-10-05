public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var anagrams = new Dictionary<string, IList<string>>();
        
        foreach(var str in strs)
        {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string sorted = new string(chars);

            if(!anagrams.ContainsKey(sorted))
            {
                anagrams[sorted] = new List<string>();
            }

            anagrams[sorted].Add(str);
        }

        return anagrams.Values.ToList();
    }
}