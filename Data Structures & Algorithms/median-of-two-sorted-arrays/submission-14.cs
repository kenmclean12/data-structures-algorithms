public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
       List<int> list = new();
       foreach (int num in nums1) list.Add(num);
       foreach (int num in nums2) list.Add(num);
       list.Sort((a, b) => a.CompareTo(b));

       int left = 0;
       int right = list.Count - 1;
       int mid = left + (right - left) / 2;

       if (list.Count % 2 == 0) {
         return (double)(list[mid] + list[mid + 1]) / 2;
       } else {
         return (double)list[mid];
       }
    }
}
