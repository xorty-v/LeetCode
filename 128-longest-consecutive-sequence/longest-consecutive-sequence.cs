public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        var numSet = new HashSet<int>(nums);
        int longest = 0;

        foreach(var num in numSet)
        {
            if(!numSet.Contains(num - 1))
            {
                int counter = 1;
                while(numSet.Contains(num + counter))
                {
                    counter++;
                }

                longest = Math.Max(longest, counter);
            }   
        }

        return longest;
    }
}