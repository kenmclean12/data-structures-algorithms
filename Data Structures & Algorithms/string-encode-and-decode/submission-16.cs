public class Solution {
    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < strs.Count; i++) {
            var str = strs[i];
            sb.Append(str.Length);
            sb.Append('#');
            sb.Append(str);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var list = new List<string>();

        int i = 0;
        while (i < s.Length) {
            var lengthStr = "";
            while (s[i] != '#') {
                lengthStr += s[i];
                i++;
            }

            var length = int.Parse(lengthStr);
            i++;

            var str = "";
            for (int k = 0; k < length; k++) {
                str += s[i];
                i++;
            }

            list.Add(str);
        }

        return list;
    }
}
