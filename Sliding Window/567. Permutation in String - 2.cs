public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        var set = new Dictionary<char, int>();

        foreach (var c in s1)
        { 
            if(!set.ContainsKey(c))
                set.Add(c, 0);
            set[c]++;
        }

        int k = s1.Length;
        var dictCopy = new Dictionary<char, int>(set);

        int offset = 0;

        for (int i = 0; i < s2.Length; i++)
        {
            if (dictCopy.ContainsKey(s2[i]) && dictCopy[s2[i]] > 0)
            {
                k--;
                dictCopy[s2[i]]--;
                if (k == 0)
                    return true;
            }
            else
            {
                k = s1.Length;
                i = offset;
                offset++;
                dictCopy = new Dictionary<char, int>(set);
            }
        }

        return false;
    }
}