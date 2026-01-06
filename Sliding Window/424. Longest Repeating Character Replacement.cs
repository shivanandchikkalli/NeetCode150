public class Solution {
    public int CharacterReplacement(string s, int k) {
        int left = 0;
        int right = 0;
        var dict = new Dictionary<char, int>();
        int res = 0;

        var maxFreq = 0;

        while (true)
        {
            if (dict.ContainsKey(s[right]))
                dict[s[right]]++;
            else
                dict[s[right]] = 1;

            maxFreq = Math.Max(maxFreq, dict[s[right]]);

            while ((right - left + 1) - maxFreq > k)
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