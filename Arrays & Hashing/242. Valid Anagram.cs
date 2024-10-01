    public static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var dict = new Dictionary<char, int>();

        foreach (char c in s) 
        {
            if (dict.ContainsKey(c))
                dict[c]++;
            else 
                dict.Add(c,1);
        }

        foreach (char c in t)
        { 
            if(dict.ContainsKey(c) && dict[c] > 0)
                dict[c]--;
            else
                return false;
        }

        return true;
    }