public class KthLargest {

    PriorityQueue<int, int> PriorityQueue = new();
    public int max = 0;

    public KthLargest(int k, int[] nums)
    {
        this.max = k;
        foreach (int num in nums)
            Add(num);
    }

    public int Add(int val)
    {
        PriorityQueue.Enqueue(val, val);
        if (PriorityQueue.Count > this.max)
            PriorityQueue.Dequeue();

        return PriorityQueue.Peek();
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */