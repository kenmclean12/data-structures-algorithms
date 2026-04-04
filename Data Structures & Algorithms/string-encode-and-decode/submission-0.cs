public class Solution {
    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        var strArray = strs.ToArray();
        for (int i = 0; i < strArray.Length; i++) {
            var str = strArray[i];
            sb.Append(str.Length);
            sb.Append('#');
            sb.Append(str);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
         List<string> result = new List<string>();
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
            for (int k = 0; k < length; k++) {
                str += s[i];
                i++;
            }

            result.Add(str);
        }

        return result;
    }
}
