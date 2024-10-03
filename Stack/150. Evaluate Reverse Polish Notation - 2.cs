// Method 2 : Using recursion

public int EvalRPN(string[] tokens)
    {
        int leastIndexVisited = int.MaxValue;
        return Evaluate(tokens, tokens.Length - 1);

        int Evaluate(string[] tokens, int index)
        {
            leastIndexVisited = Math.Min(index, leastIndexVisited);
            if (tokens[index] is "+" or "-" or "/" or "*")
            {
                int value1 = Evaluate(tokens, index - 1);
                int value2 = Evaluate(tokens, leastIndexVisited - 1);

                Console.WriteLine($"{value2} {tokens[index]} {value1}");

                var result = tokens[index] switch
                {
                    "+" => value2 + value1,
                    "-" => value2 - value1,
                    "/" => value2 / value1,
                    "*" => value2 * value1,
                };

                return result;
            }
            else
            {
                return Convert.ToInt32(tokens[index]);
            }
        }      
    }