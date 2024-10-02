    public static string Encode(IList<string> strs)
    {
        if (strs.Count == 0) return null;

        var outputString = string.Join(",", strs);

        var result = string.Empty;
        foreach (char str in outputString)
            result += Convert.ToChar(str + 3);

        return result;
    }

    public static List<string> Decode(string s)
    {
        if (s == null) return new List<string>();

        if (s.Length <= 0) return new List<string>() { string.Empty };

        var originalString = string.Empty;

        foreach (var str in s)
            originalString += Convert.ToChar(str - 3);

        return originalString.Split(',').ToList();
    }