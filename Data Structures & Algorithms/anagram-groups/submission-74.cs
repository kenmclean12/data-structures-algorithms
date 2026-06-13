public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new();

        foreach (string str in strs) {
            int[] count = new int[128];
            for (int i = 0; i < str.Length; i++) {
                count[str[i]]++;
            }

            string key = String.Join(",", count);
            if (!map.ContainsKey(key)) {
                map[key] = new List<string>();
            }

            map[key].Add(str);
        }

        return map.Values.ToList<List<string>>();
    }
}