public class Solution {
    public int LongestConsecutive(int[] nums) {
            var dict = new Dictionary<int, bool>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                    dict.Add(nums[i], false);
            }

            var longR = 0;

            foreach (int num in dict.Keys)
            {
                // Ignore all those numbers which will be part of some sequence 
                // Ignore those number which are not first number of the sequence
                if (dict.ContainsKey(num - 1))
                    continue;

                int k = 1;

                while (dict.ContainsKey(num + k))
                {
                    dict[num + k] = true;
                    k++;
                }

                longR = Math.Max(longR, k);
            }

            return longR;
    }
}