public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new();
        
        for (int i = 0; i < strs.Length; i++) {
            string str = strs[i];
            char[] charArr = str.ToCharArray();
            Array.Sort(charArr);
            string key = new String(charArr);

            if (!map.ContainsKey(key)) {
                map[key] = new List<string>();
            }

            map[key].Add(str);
        }

        return map.Values.ToList<List<string>>();
    }
}