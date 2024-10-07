public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        var hashSet = new HashSet<int>(nums);
        int longest = 0;

        foreach(var num in nums)
        {
            if(hashSet.Contains(num - 1))
            {
                continue;
            }

            int counter = 1;
            while(hashSet.Contains(num + counter))
            {
                counter++;
            }

            longest = Math.Max(longest, counter);
        }

        return longest;
    }
}