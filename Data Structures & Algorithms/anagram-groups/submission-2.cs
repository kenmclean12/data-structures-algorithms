public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
       var map = new Dictionary<string, List<string>>();
       for (int i = 0; i < strs.Length; i++) {
         var str = strs[i];
         var charArr = str.ToCharArray();
         Array.Sort(charArr);
         var tag = new string(charArr);

         if (!map.ContainsKey(tag)) {
            map[tag] = new List<string>();
         }

         map[tag].Add(strs[i]);
       }

       return map.Values.ToList();
    }
}