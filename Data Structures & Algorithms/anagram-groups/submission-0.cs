public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Length; i++) {
            var word = strs[i];
            var chars = word.ToCharArray();
            Array.Sort(chars);
            var key = new string(chars);

            if (!map.ContainsKey(key)) {
                map[key] = new List<string>();
            }

            map[key].Add(word);
        }

        return map.Values.ToList();
    }
}
