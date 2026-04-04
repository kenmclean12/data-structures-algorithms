public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        var sCharArray = s.ToCharArray();
        var tCharArray = t.ToCharArray();

        Array.Sort(sCharArray);
        Array.Sort(tCharArray);

        var sStr = new string(sCharArray);
        var tStr = new string(tCharArray);

        return sStr == tStr;
    }
}
