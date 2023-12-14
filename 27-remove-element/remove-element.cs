public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int writer = 0;
        int reader = 0;

        for (reader = 0; reader < nums.Length; reader++)
        {
            if(nums[reader] != val)
            {
                nums[writer++] = nums[reader];
            }
        }

        return writer;
    }
}