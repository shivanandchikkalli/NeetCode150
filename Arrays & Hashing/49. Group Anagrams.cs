    public static IList<IList<string>> GroupAnagrams2(string[] strs)
    {
        var dict = new Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            var thisString = string.Concat(strs[i].OrderBy(c => c));
            if (!dict.ContainsKey(thisString))
            {
                dict.Add(thisString, new List<string>());
            }
            dict[thisString].Add(strs[i]);
        }

        return new List<IList<string>>(dict.Values);
    }