public int LongestValidParentheses(string s)
{
    int max = 0;
    int len = 0;

    Stack<int> stack = new Stack<int>();
	char[] chars = new char[s.Length];
	
    if (string.IsNullOrEmpty(s))
    {
        return 0;
    }
    else
    {
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                stack.Push(i);
            }
            else
            {
                if (stack.Count > 0)
                {
                    int index = stack.Pop();

                    chars[i] = '1';
                    chars[index] = '1';
                }
                else
                {
                    continue;
                }
            }
        }


        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] == '1')
            {
                len++;

                if (len > max)
                {
                    max = len;
                }
            }
            else
            {
                len = 0;
            }
        }
    }

    return max;
}