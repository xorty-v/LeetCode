public class Solution {
    public int MaxSubArray(int[] nums) 
    {
        int curSum = 0;
        int maxSum = nums[0];

        foreach(var num in nums)
        {
            if(curSum < 0)
                curSum = 0;

            curSum += num;
            maxSum = Math.Max(maxSum, curSum);
        }

        return maxSum;
    }
}