public class Solution {
    public bool IsHappy(int n) 
    {
        var set = new HashSet<int>();

        while(!set.Contains(n))
        {
            set.Add(n);
            n = SumOfSquares(n);

            if(n == 1)
                return true;
        }

        return false;
    }

    public int SumOfSquares(int n)
    {
        int sum = 0;

        while(n > 0)
        {
            int number = n % 10;
            sum += number * number;
            n /= 10;
        }

        return sum;
    }
}