public class Solution {
    public string Encode(IList<string> strs) {
        StringBuilder sb = new();
        for (int i = 0; i < strs.Count; i++) {
            string str = strs[i];
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

            int length = int.Parse(lengthStr);
            i++;

            string str = "";
            for (int j = 0; j < length; j++) {
                str += s[i];
                i++;
            }

            list.Add(str);
        }

        return list;
    }
}
