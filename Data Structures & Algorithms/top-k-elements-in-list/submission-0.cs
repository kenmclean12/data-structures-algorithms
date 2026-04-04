public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            var num = nums[i];
            if (!map.ContainsKey(num)) {
                map[num] = 0;
            }
            map[num]++;
        }

        return map
            .OrderByDescending(x => x.Value)
            .Take(k)
            .Select(x => x.Key)
            .ToArray();
    }
}
