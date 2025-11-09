public class NumArray 
{
    private readonly int[] _prefixNums;

    public NumArray(int[] nums)
    {
        _prefixNums = new int[nums.Length];

        for(var i = 0; i < nums.Length; i++)
        {
            _prefixNums[i] = i == 0 ? nums[i] : _prefixNums[i - 1] + nums[i];
        }
    }
    
    public int SumRange(int left, int right)
    {
        return left == 0 ? _prefixNums[right] : _prefixNums[right] - _prefixNums[left - 1];
    }
}