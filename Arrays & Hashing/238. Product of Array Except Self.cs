public static int[] ProductExceptSelf(int[] nums)
{
    int[] output = new int[nums.Length];

    int prefix = 1;
    output[0] = 1;
    for (int i = 0; i < nums.Length; i++)
    { 
        if(i + 1 < nums.Length)
            output[i + 1] = prefix * nums[i];

        prefix *= nums[i];
    }

    int postfix = 1;
    for (int i = nums.Length - 1; i >= 0; i--)
    { 
        if(i - 1 >= 0)
            output[i - 1] *= postfix * nums[i];

        postfix *= nums[i];
    }

    return output;
}