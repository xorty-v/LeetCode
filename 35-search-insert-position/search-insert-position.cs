public class Solution {
    public int SearchInsert(int[] nums, int target) 
    {
        int lowIndex = 0;
        int highIndex = nums.Length - 1;

        while(lowIndex < highIndex)
        {
            int middleIndex = (lowIndex + highIndex) / 2;

            if(nums[middleIndex] == target)
                return middleIndex;

            if(nums[middleIndex] < target)
                lowIndex = middleIndex + 1;

            if(nums[middleIndex] > target)
                highIndex = middleIndex - 1;
        }

        return nums[lowIndex] >= target ? lowIndex : lowIndex + 1; 
    }
}