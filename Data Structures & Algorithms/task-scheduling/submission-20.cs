public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        int length = tasks.Length;
        int[] count = new int[26];
        for (int i = 0; i < length; i++) {
            count[tasks[i] - 'A']++;
        }

        int maxFreq = count.Max();
        int maxCount = count.Count(c => c == maxFreq);

        return Math.Max(tasks.Length, (maxFreq - 1) * (n + 1) + maxCount);
    }
}
