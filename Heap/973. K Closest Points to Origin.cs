public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var queue = new PriorityQueue<int[], double>();

        foreach (int[] num in points)
        {
            var distanceFromOrigin = Math.Sqrt( ((0 - num[0]) * (0 - num[0])) + ( (0 - num[1]) * (0 - num[1]) ));
            queue.Enqueue(num, distanceFromOrigin);
        }

        var result = new int[k][];
        int index = 0;
        while(index < k)
            result[index++] = queue.Dequeue();

        return result;        
    }
}