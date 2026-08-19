public class Solution {
    public string Encode(IList<string> strs) {
       StringBuilder sb = new();
       foreach (string str in strs) {
        sb.Append(str.Length);
        sb.Append('#');
        sb.Append(str);
       }

       return sb.ToString();
    }

    public List<string> Decode(string s) {
       List<string> list = new();

       int i = 0;
       while (i < s.Length) {
         string lengthStr = "";
         while (s[i] != '#') {
           lengthStr += s[i];
           i++;
         }

         int len = int.Parse(lengthStr);
         i++;

         string word = "";
         for (int j = 0; j < len; j++) {
           word += s[i];
           i++;
         }

         list.Add(word);
       }

       return list;
    }
}
