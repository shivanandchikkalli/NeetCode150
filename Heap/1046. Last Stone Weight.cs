public class Solution {
    public int LastStoneWeight(int[] stones) {
        var queue = new PriorityQueue<int, int>();

        foreach (int num in stones)
            queue.Enqueue(num, num * -1);

        while (queue.Count > 1)
        { 
            var num2 = queue.Dequeue();
            var num1 = queue.Dequeue();
            if (num1 == num2)
                continue;
            var diff = num2 - num1;
            queue.Enqueue(diff, diff * -1);
        }

        if(queue.Count > 0)
            return queue.Dequeue();
        return 0;
    }
}