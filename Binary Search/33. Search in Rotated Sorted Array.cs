public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int center = left + (right - left) / 2;

            if (nums[center] == target)
                return center;

            if (nums[left] <= nums[center])
            {
                if (target > nums[center] || target < nums[left])
                    left = center + 1;
                else
                    right = center - 1;
            }
            else
            {
                if (target < nums[center] || target > nums[right])
                    right = center - 1;
                else
                    left = center + 1;
            }
        }

        return -1;
    }
}