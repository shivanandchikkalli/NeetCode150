    public static int[] TwoSum(int[] numbers, int target)
    {

        var i = 0;
        var j = 1;
        var rev = false;
        while (true)
        {
            var sum = numbers[i] + numbers[j];
            if (sum == target) 
                return new int[]{i + 1, j + 1};
            else if (sum < target)
            {
                if (j == numbers.Length - 1 || rev) i++;
                else j++;
            }
            else if (sum > target)
            {
                j--;
                rev = true;
            }
        }

    }