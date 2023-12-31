public class Solution {
    public int MajorityElement(int[] nums) 
    {
        var dict = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (dict.ContainsKey(num))
               dict[num]++;
           else
               dict.Add(num, 1);
        }
    
        return dict.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
    }
}