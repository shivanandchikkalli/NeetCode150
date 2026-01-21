public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1;
        int right = piles.Max();
        int result = right;

        while (left <= right)
        { 
            int k = (right + left) / 2;

            long totalTimeTaken = 0; // This is important to be long to avoid overflow
            foreach (int pile in piles)
            {
                totalTimeTaken += (int)Math.Ceiling((double)pile / k);
            }

            if (totalTimeTaken <= h)
            {
                result = Math.Min(result, k);
                right = k - 1;
            }
            else
                left = k + 1;
        }
        return result;        
    }
}