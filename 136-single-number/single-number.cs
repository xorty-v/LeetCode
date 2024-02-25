public class Solution {
    public int SingleNumber(int[] nums) 
    {
        int singleNumber = 0;

        foreach(var num in nums)
        {
            singleNumber ^= num;
        }

        return singleNumber;
    }
}