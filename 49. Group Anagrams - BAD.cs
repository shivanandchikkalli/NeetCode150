    // Time Complexity - O(N * M + N2 * M)
    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var dict = new Dictionary<string, bool>();

        IList<IList<string>> result = new List<IList<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            if (!dict.ContainsKey(strs[i]))
            {
                var anagrams = new List<string>();
                anagrams.Add(strs[i]);
                dict.Add(strs[i], true);

                int k = i + 1;
                while (k < strs.Length)
                {
                    if (strs[i] == strs[k] || CheckAnangram(strs[i], strs[k]))
                    {
                        anagrams.Add(strs[k]);
                        if(!dict.ContainsKey(strs[k]))
                            dict.Add(strs[k], true);
                    }
                    k++;
                }
                result.Add(anagrams);
            }
        }

        return result;

        static bool CheckAnangram(string one, string two)
        {
            bool result = true;

            if (one.Length != two.Length)
                return false;

            var uDict = new Dictionary<char, int>();
            foreach (var str in one)
            {
                if (!uDict.ContainsKey(str))
                    uDict.Add(str, 1);
                else
                    uDict[str]++;
            }
            foreach (var str in two)
            {
                if (!uDict.ContainsKey(str) || uDict[str] <= 0)
                    return false;
                else
                    uDict[str]--;
            }

            return result;
        }
    }