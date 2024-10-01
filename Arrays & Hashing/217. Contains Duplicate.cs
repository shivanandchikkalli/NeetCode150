    public static bool ContainsDuplicate(int[] nums)
    {
        return nums.Distinct().Count() == nums.Length;

        //Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

        //foreach (int num in nums)
        //{
        //    if (keyValuePairs.ContainsKey(num))
        //        return true;
        //    else
        //        keyValuePairs.Add(num, num);
        //}

        //return false;
    }