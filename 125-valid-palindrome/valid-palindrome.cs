public class Solution {
    public bool IsPalindrome(string s) 
    {
        string text = new string(s.ToLower().Where(char.IsLetterOrDigit).ToArray());

        int left = 0;
        int right = text.Length - 1;

        while(left <= right)
        {
            if(text[left++] != text[right--])
                return false;
        }

        return true;
    }
}