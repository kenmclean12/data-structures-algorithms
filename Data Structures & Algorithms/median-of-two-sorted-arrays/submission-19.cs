public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
       List<int> list = nums1.Concat(nums2).ToList();
       list.Sort();

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
