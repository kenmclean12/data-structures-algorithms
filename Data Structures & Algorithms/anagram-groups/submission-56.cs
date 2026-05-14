public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new();

        foreach (string str in strs) {
            string lower = str.ToLower();
            int[] count = new int[26];

            for (int i = 0; i < lower.Length; i++) {
                count[lower[i] - 'a']++;
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