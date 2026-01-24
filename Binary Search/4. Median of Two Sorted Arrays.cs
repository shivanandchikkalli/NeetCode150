public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int totalLength = nums1.Length + nums2.Length;
        int[] merged = new int[totalLength];
        int center = (totalLength - 1) / 2;
        int left = 0;
        int right = 0;
        int index = 0;
        while (left < nums1.Length && right < nums2.Length)
        {
            if (nums1[left] <= nums2[right])
                merged[index++] = nums1[left++];
            else if (nums1[left] > nums2[right])
                merged[index++] = nums2[right++];
        }
        while(left < nums1.Length)
            merged[index++] = nums1[left++];

        while (right < nums2.Length)
            merged[index++] = nums2[right++];

        if (totalLength % 2 == 0)
            return (double)(merged[center] + merged[center + 1]) / 2;
        else
            return merged[center];
    }
}