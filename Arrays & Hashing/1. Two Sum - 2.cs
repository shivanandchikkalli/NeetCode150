public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();

        for (int i = 0 ; i < nums.Length ; i++)
        { 
            var reqNum = target - nums[i];

            if (dict.ContainsKey(reqNum))
                return [i, dict[reqNum]];

            dict[nums[i]] = i;
        }

        return [-1, -1];
    }
}