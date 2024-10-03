    public static bool IsPalindrome(string s)
    {
        var sb = new StringBuilder();

        for (int i = 0; i < s.Length; i++)
        {
            if ((s[i] >= 'A' && s[i] <= 'Z') || (s[i] >= 'a' && s[i] <= 'z') || (s[i] >= '0' && s[i] <= '9'))
                sb.Append(s[i]);
        }
        
        var thisString = sb.ToString().ToLower();

        for (int i = 0; i < thisString.Length; i++)
        {
            if (thisString[i] != thisString[thisString.Length - 1 - i])
                return false;
        }

        return true;
    }