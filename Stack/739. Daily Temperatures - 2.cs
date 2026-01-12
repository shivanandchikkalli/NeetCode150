public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var _stack = new Stack<(int, int)>();
        var result = new int[temperatures.Length];

        var index = 0;
        while (index < temperatures.Length)
        {
            while (_stack.Count > 0 && _stack.Peek().Item1 < temperatures[index])
            { 
                var top = _stack.Pop();
                result[top.Item2] = index - top.Item2;
            }
            _stack.Push((temperatures[index], index));
            index++;
        }

        while (_stack.Count > 0)
        { 
            var top = _stack.Pop();
            result[top.Item2] = 0;
        }

        return result;        
    }
}