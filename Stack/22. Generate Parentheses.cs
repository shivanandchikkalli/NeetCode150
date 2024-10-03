    public static IList<string> GenerateParenthesis(int n)
    {
        var result = new List<string>();

        Dummy(string.Empty, 0, 0);

        void Dummy(string item, int openN, int closeN)
        {
            if (openN == closeN && openN == n)
            {
                result.Add(item);
                return;
            }
            
            if (openN < n)
            {
                Dummy(item + "(", openN + 1, closeN);
            }

            if (closeN < openN)
            {
                Dummy(item + ")", openN, closeN + 1);
            }
        }

        return result;
    }