public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        var list = new List<char>(ransomNote);
        int count = 0;

        foreach(var c in magazine)
        {
            if(list.Remove(c))
                count++;
        }

        return ransomNote.Length == count;
    }
}