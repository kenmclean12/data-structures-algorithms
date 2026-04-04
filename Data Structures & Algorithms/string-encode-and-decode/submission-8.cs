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
        var result = new List<string>();

        int i = 0;
        while (i < s.Length) {
            string strLength = "";
            while (s[i] != '#') {
                strLength += s[i];
                i++;
            }
            int numLength = int.Parse(strLength);
            i++;

            string str = "";
            for (int k = 0; k < numLength; k++) {
                str += s[i];
                i++;
            }

            result.Add(str);
        }

        return result;
    }
}
