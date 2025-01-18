public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (!dict.ContainsKey(num))
            {
                dict.Add(num, 0);
            }

            dict[num]++;
        }

        return dict.OrderByDescending(kvp => kvp.Value).Take(k).Select(kvp => kvp.Key).ToArray();
    }
}