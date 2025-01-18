public class Solution 
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var anagrams = new Dictionary<string, IList<string>>();

        foreach (var str in strs)
        {
            string sorted = new string(str.OrderBy(c => c).ToArray());

            if (!anagrams.ContainsKey(sorted))
            {
                anagrams[sorted] = new List<string>();
            }

            anagrams[sorted].Add(str);
        }

        return anagrams.Values.ToList();
    }
}