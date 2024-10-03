public static IList<IList<int>> ThreeSum(int[] nums)
{
    if(nums.Length < 3)
        return new List<IList<int>>();

    nums = nums.Order().ToArray();

    var result = new List<IList<int>>();
    var firstNumberStorage = new HashSet<string>();

    for (int i = 0; i < nums.Length; i++)
    {
        int currentNumber = nums[i];

        var left = i + 1;
        var right = nums.Length - 1;

        while (left < right)
        {
            if (currentNumber + nums[left] + nums[right] == 0) {
                if (!firstNumberStorage.Contains(string.Concat(currentNumber, nums[left], nums[right])))
                {
                    firstNumberStorage.Add(string.Concat(currentNumber, nums[left], nums[right]));
                    result.Add(new List<int> { currentNumber, nums[left], nums[right] });
                }
                right--;
            }
            else if (currentNumber + nums[left] + nums[right] > 0)
                right--;
            else if (currentNumber + nums[left] + nums[right] < 0)
                left++;
        }
    }

    return result;
}