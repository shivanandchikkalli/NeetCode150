    public static int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        { 
            int reqTarget = target - nums[i];
            if (dict.TryGetValue(reqTarget, out int value))
                return new int[]{ i, value };
            else if(!dict.ContainsKey(nums[i]))
                dict.Add(nums[i], i);
        }

        return Array.Empty<int>();
    }