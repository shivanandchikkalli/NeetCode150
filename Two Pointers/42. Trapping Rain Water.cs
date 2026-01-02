public class Solution {
    public int Trap(int[] height) {
        var maxLeftArray = new int[height.Length];
        var maxRightArray = new int[height.Length];

        maxLeftArray[0] = 0;
        for (int i = 1; i < height.Length; i++)
        {
            maxLeftArray[i] = Math.Max(maxLeftArray[i-1], height[i-1]);
        }

        maxRightArray[height.Length - 1] = 0;
        for (int i = height.Length - 2; i > 0; i--)
        {
            maxRightArray[i] = Math.Max(maxRightArray[i + 1], height[i + 1]);
        }

        int sum = 0;
        for (int i = 0; i < height.Length; i++)
        {
            var thiSum = Math.Min(maxLeftArray[i], maxRightArray[i]) - height[i];
            sum += thiSum > 0 ? thiSum : 0;
        }

        return sum;        
    }
}