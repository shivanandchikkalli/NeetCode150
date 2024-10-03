    public static bool IsValid(string s)
    {
        switch (s.Length)
        {
            case 0:
                return true;
            case 1:
                return false;
        }

        Stack<char> st = new();
        
        foreach (var t in s)
        {
            Console.WriteLine(t);
            if(t is '(' or '[' or '{')
                st.Push(t);
            else if (!st.Any() && t is ')' or ']' or '}')
                return false;
            else switch (t)
            {
                case ')' when st.Peek() == '(':
                case ']' when st.Peek() == '[':
                case '}' when st.Peek() == '{':
                    st.Pop();
                    break;
                default:
                    return false;
            }
        }
        
        return !st.Any();
    }