public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new();

        foreach (string str in strs) {
            int[] count = new int[26];
            for (int i = 0; i < str.Length; i++) {
                count[str[i] - 'a']++;
            }

            string key = string.Join(',', count);
            if (!map.ContainsKey(key)) {
                map[key] = new List<string>();
            }

            map[key].Add(str);
        }

        return map.Values.ToList<List<string>>();
    }
}