public class Solution {
    public bool IsAnagram(string s, string t) 
    {  
        char[] firstChars = s.ToCharArray();
        Array.Sort(firstChars);
        string firstSorted = new string(firstChars);

        char[] secondChars = t.ToCharArray();
        Array.Sort(secondChars);
        string secondSorted = new string(secondChars);

        return firstSorted == secondSorted;
    }
}