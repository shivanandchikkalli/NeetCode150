    public class MinStack
    {
        private Stack<(int, int)> _stack;

        public MinStack()
        {
            _stack = new Stack<(int, int)>();
        }

        public void Push(int val)
        {
            ArgumentNullException.ThrowIfNull(_stack);

            if (_stack.Count == 0)
                _stack.Push((val, val));
            else
                _stack.Push((val, Math.Min(_stack.Peek().Item2, val)));
        }

        public void Pop()
        {
            ArgumentNullException.ThrowIfNull(_stack);

            _stack.Pop();
        }

        public int Top()
        {
            ArgumentNullException.ThrowIfNull(_stack);

            if (_stack.Count == 0) return 0;

            return _stack.Peek().Item1;
        }

        public int GetMin()
        {
            ArgumentNullException.ThrowIfNull(_stack);

            if (_stack.Count == 0) return 0;

            return _stack.Peek().Item2;
        }
    }