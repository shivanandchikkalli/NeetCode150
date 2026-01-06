public class Solution {
    public int CharacterReplacement(string s, int k) {
        int left = 0;
        int right = 0;
        var dict = new Dictionary<char, int>();
        int res = 0;

        while (true)
        {
            if (dict.ContainsKey(s[right]))
                dict[s[right]]++;
            else
                dict[s[right]] = 1;

            while((right - left + 1) - (dict.Values.Count > 0 ? dict.Values.Max() : 0) > k)
            {
                dict[s[left]]--;
                left++;
            }

            res = Math.Max(res, (right - left + 1));

            right++;
            if (right == s.Length)
                return res;
        }
    }
}