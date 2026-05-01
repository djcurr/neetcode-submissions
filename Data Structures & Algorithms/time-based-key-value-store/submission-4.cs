public class TimeMap {
    Dictionary<string, List<Val>> dict;
    public TimeMap() {
        dict = new Dictionary<string, List<Val>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        Val value1 = new Val(value, timestamp);
        if (dict.ContainsKey(key)) {
           dict[key].Add(value1);
        } else {
            dict[key] = new List<Val> { value1 };
        }
    }
    
    public string Get(string key, int timestamp) {
        if (!dict.ContainsKey(key)) return "";
        var vals = dict[key];
        int f = 0;
        int l = vals.Count - 1;
        while (f <= l) {
            int mid = (f + l) / 2;
            if (timestamp >= vals[mid].Timestamp) {
                f = mid + 1;
            } else {
                l = mid - 1;
            }
        }
        return l >= 0 ? vals[l].Value : "";
    }

    private class Val 
    {
        public string Value { get; set; }
        public int Timestamp { get; set; }

        public Val(string value, int ts) {
            Value = value;
            Timestamp = ts;
        }
    }

}
