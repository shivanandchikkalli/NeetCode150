public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        var stack = new Stack<decimal>();

        (int position, int speed)[] array = new(int position, int speed)[position.Length];

        int index = 0;
        while (index < array.Length)
        {
            array[index] = (position[index], speed[index]);
            index++;
        }

        array = array.OrderBy(static x => x.position).Reverse().ToArray();

        for (int i = 0; i < array.Length; i++)
        {
            decimal timeToReach = (decimal)(target - array[i].position) / array[i].speed;

            stack.Push(timeToReach);
            if (stack.Count >= 2 && stack.Peek() <= stack.ElementAt(1))
                stack.Pop();
        }

        return stack.Count;
    }
}