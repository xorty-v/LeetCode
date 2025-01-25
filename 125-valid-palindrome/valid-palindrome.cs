public class Solution {
    public bool IsPalindrome(string s) 
    {
        int left = 0;
        int right = s.Length - 1;

        s = s.ToLower();

        while(left < right)
        {
            if(!char.IsLetterOrDigit(s[left]))
            {
                left++;
                continue;
            }

            if(!char.IsLetterOrDigit(s[right]))
            {
                right--;
                continue;
            }

            if(s[left] != s[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}