public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
         var map = new Dictionary<string, List<string>>();
         for (int i = 0; i < strs.Length; i++) {
            var str = strs[i];
            var charArr = str.ToCharArray();
            Array.Sort(charArr);
            var key = new string(charArr);

            if (!map.ContainsKey(key)) {
               map[key] = new List<string>();
            }

            map[key].Add(str);
         }

         return map.Values.ToList<List<string>>();
    }
}