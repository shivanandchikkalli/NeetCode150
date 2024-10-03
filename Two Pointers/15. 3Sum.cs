    public IList<IList<int>> ThreeSum(int[] nums) {
        if(nums.Length < 3)
            return new List<IList<int>>();

        nums = nums.Order().ToArray();

        var result = new List<IList<int>>();
        var firstNumberStorage = new HashSet<string>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) 
                continue;

            int currentNumber = nums[i];

            var left = i + 1;
            var right = nums.Length - 1;

            while (left < right)
            {
                if (currentNumber + nums[left] + nums[right] == 0) {
                    result.Add(new List<int> { currentNumber, nums[left], nums[right] });
                    right--;
                    left++;
                    while (left < right && nums[left] == nums[left - 1])
                        left++;
                }
                else if (currentNumber + nums[left] + nums[right] > 0)
                    right--;
                else if (currentNumber + nums[left] + nums[right] < 0)
                    left++;
            }
        }

        return result;        
    }