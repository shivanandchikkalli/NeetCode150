public class Solution {

    // Think monotoic decreasing stack with top and bottom removals
    // AddLast is Push
    // RemoveFirst is Removing bottom element
    // Adding/Removing indices of elements in the array instead of elements themselves
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        LinkedList<int> deque = new();

        int R = 0;

        var res = new int[nums.Length - k + 1];

        while (R < nums.Length)
        {
            // take care of window - remove if first element is outside window
            // because it is no longer part of the sliding window
            if (deque.Count > 0 && deque.First.Value < R - k + 1)
                deque.RemoveFirst();

            // remove elements from queue as long as last value is smaller than current value
            // because they will never be maximum in this window or future windows
            while (deque.Count > 0 && nums[deque.Last.Value] < nums[R])
                deque.RemoveLast();

            deque.AddLast(R);

            // if window size is equal to k then take fron of queue and add it to output array
            // as it is maximum for this window
            if (R >= k - 1)
                res[R - k + 1] = nums[deque.First.Value];

            R++;
        }
        
        return res;
    }
}