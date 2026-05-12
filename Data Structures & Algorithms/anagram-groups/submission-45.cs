public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new();

        for (int i = 0; i < strs.Length; i++) {
            var str = strs[i];
            int[] count = new int[26];
            for (int j = 0; j < str.Length; j++) {
                count[str[j] - 'a']++;
            }

            string key = String.Join(",", count);
            if (!map.ContainsKey(key)) {
                map[key] = new List<string>();
            }

            map[key].Add(str);
        }

        return map.Values.ToList();
    }
}