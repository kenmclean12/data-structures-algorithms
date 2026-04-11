public class TimeMap {
    Dictionary<string, List<(int timestamp, string value)>> map = new();
    public TimeMap() {
        map = new();
    }
    
    public void Set(string key, string value, int timestamp) {
        if (!map.ContainsKey(key)) map[key] = [];
        map[key].Add((timestamp, value));
    }
    
    public string Get(string key, int timestamp) {
        if (!map.ContainsKey(key)) return "";
        var list = map[key];
        int left = 0;
        int right = list.Count - 1;
        string result = "";

        while (left <= right) {
            int mid = left + (right - left) / 2;
            if (list[mid].timestamp <= timestamp) {
                result = list[mid].value;
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }

        return result;
    }
}
