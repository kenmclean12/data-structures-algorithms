public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        List<int> list = new();
        for (int i = 0; i < nums1.Length; i++) list.Add(nums1[i]);
        for (int i = 0; i < nums2.Length; i++) list.Add(nums2[i]);
        list.Sort((a, b) => a.CompareTo(b));

        int left = 0;
        int right = list.Count - 1;
        int mid = left + (right - left) / 2;

        if (list.Count % 2 == 0) {
            return (list[mid] + list[mid + 1]) / 2.0;
        } else {
            return (double)list[mid];
        }
    }
}
