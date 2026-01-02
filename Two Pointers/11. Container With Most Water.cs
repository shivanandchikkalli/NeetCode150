public class Solution {
    public int MaxArea(int[] height) {
            var maxArea = 0;

            if (height.Length < 2)
                return 0;
            else if (height.Length == 2)
                return Math.Min(height[0], height[1]) * 1;

            int left = 0;
            int right = height.Length - 1;

            while (left != right)
            {
                int cWidth = right - left;
                int cHeight = Math.Min(height[left], height[right]);

                int area = cWidth * cHeight;

                maxArea = Math.Max(maxArea, area);

                if (height[left] < height[right])
                    left++;
                else if (height[right] < height[left])
                    right--;
                else
                    left++;
            }

            return maxArea;
    }
}