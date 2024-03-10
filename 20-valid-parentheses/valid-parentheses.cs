public class Solution {
    public bool IsValid(string s) 
    {
        var stack = new Stack<char>();

        foreach(var c in s)
        {
            switch(c)
            {
                case '(':  
                case '{':
                case '[':
                    stack.Push(c);
                    break;
                case ')': if(!IsValid('(')) return false;
                    break;
                case '}': if(!IsValid('{')) return false;
                    break;
                case ']': if(!IsValid('[')) return false;
                    break;
            }
        }

        return stack.Count == 0;

        bool IsValid(char openChar)
        {
            if (stack.Count == 0 || stack.Pop() != openChar)
                return false;

            return true;
        }
    }
}