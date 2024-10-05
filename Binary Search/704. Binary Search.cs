    public static int Search(int[] nums, int target)
    {
        if (nums.Length == 1)
            return nums[0] == target ? 0 : -1;
        int left = 0;
        int right = nums.Length - 1;
        int center = (left + right) / 2;

        while (left <= right)
        {
            if (target == nums[center]) 
                return center;
            else if (target > nums[center])
            {
                left = center + 1;
            }
            else if (target < nums[center])
            {
                right = center - 1;
            }
            center = (left + right) / 2;
        }

        return -1;
    }