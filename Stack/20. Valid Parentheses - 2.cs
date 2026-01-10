public class Solution {
    public bool IsValid(string s) {
        var dict = new Dictionary<char, char>
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };

        var stack = new Stack<char>();

        foreach (var c in s)
        {
            if (stack.Count > 0 && dict.ContainsKey(stack.Peek()) && c == dict[stack.Peek()])
                stack.Pop();
            else
                stack.Push(c);
        }

        return stack.Count == 0;
    }
}