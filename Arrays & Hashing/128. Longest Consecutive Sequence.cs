public static int LongestConsecutive(int[] nums)
{
    if (nums.Length == 0) return 0;

    HashSet<int> ints = new();

    foreach (int num in nums)
        if (!ints.Contains(num))
            ints.Add(num);

    int returnValue = int.MinValue;
    foreach (int num in nums)
    {
        if (!ints.Contains(num - 1))
        {
            int length = 1;
            while (ints.Contains(num + length))
                length++;
            returnValue = Math.Max(returnValue, length);
        }
    }

    return returnValue;
}