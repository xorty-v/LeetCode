public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var value = target - nums[i];

            if (dict.ContainsValue(value))
                return new int[] { dict.Where(x=>x.Value == value).First().Key, i };
            else
                dict.Add(i, nums[i]);
        }

        return null;    
    }
}