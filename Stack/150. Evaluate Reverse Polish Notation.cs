// Method 1 : Using Stack

public int EvalRPN(string[] tokens)
    {
        Stack<int> stack = new();

        for (int i = 0; i < tokens.Length; i++)
        {
            if (int.TryParse(tokens[i], out int value))
                stack.Push(value);
            else
            {
                var temp1 = stack.Pop();
                var temp2 = stack.Pop();
                temp = tokens[i] switch
                {
                    "+" => temp2 + temp1,
                    "-" => temp2 - temp1,
                    "*" => temp2 * temp1,
                    "/" => temp2 / temp1,
                    _ => throw new NotImplementedException(),
                };
                stack.Push(temp);
            }
        }
        return stack.Pop();    
    }