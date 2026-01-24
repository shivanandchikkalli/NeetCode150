public class TimeMap
{
    Dictionary<string, List<(int, string)>> storage;
    public TimeMap()
    {
        storage = new();
    }

    public void Set(string key, string value, int timestamp)
    {
        if (!storage.ContainsKey(key))
            storage.Add(key, new());

        storage[key].Add((timestamp, value));
    }

    public string Get(string key, int timestamp)
    {
        if (!storage.ContainsKey(key))
            return string.Empty;
        else if(storage.ContainsKey(key) && storage[key].Count == 1)
            return storage[key].FirstOrDefault().Item1 <= timestamp ? storage[key].FirstOrDefault().Item2 : string.Empty;


        int left = 0;
        int right = storage[key].Count - 1;
        string value = "";

        while (left <= right)
        {
            int center = left + (right - left) / 2;

            if (storage[key][center].Item1 == timestamp)
                return storage[key][center].Item2;

            if (timestamp < storage[key][center].Item1)
                right = center - 1;
            else
            {
                value = storage[key][center].Item2;
                left = center + 1;
            }
        }

        return value;
    }
}

/**
 * Your TimeMap object will be instantiated and called as such:
 * TimeMap obj = new TimeMap();
 * obj.Set(key,value,timestamp);
 * string param_2 = obj.Get(key,timestamp);
 */