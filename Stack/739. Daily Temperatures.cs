    // User monotonic stack
    public static int[] DailyTemperatures(int[] temperatures)
    {
        if (temperatures is null)
            return Array.Empty<int>();

        int[] result = new int[temperatures.Length];
        Stack<(int,int)> st = new();

        for (int i = temperatures.Length - 1; i >= 0; i--)
        {
            int currentTemp = temperatures[i];
            while (st.Count != 0 && st.Peek().Item1 <= currentTemp)
                st.Pop();
             
            // If stack is empty means, no higher temperature after the current temperature, so set to 0
            if (st.Count == 0)
                result[i] = 0;
            else
                result[i] = st.Peek().Item2 - i; // Calculate the index difference between current
                                                 // temperature and highest temperature on top of the stack

            // Add current temperature and it's index
            st.Push((currentTemp, i));
        }

        return result;
    }