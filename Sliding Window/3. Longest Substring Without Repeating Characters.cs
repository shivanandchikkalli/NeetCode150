public class Solution {
    public int LengthOfLongestSubstring(string s) {
            int maxLength = 0;

            var set = new HashSet<char>();

            int startIdx = 0;
            for (int i = 0; i < s.Length; i++)
            {
                while (set.Contains(s[i]))
                    set.Remove(s[startIdx++]);

                set.Add(s[i]);
                maxLength = Math.Max(maxLength, set.Count);
            }

            return maxLength;
    }
}