public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
      int left = 1;
      int right = piles.Max();
      int result = 0;

      while (left <= right) {
        int mid = left + (right - left) / 2;
        long hoursNeeded = HoursNeeded(piles, mid);
        if (hoursNeeded <= h) {
            result = mid;
            right = mid - 1;
        } else {
            left = mid + 1;
        }
      }

      return result;
    }

    private long HoursNeeded(int[] piles, int k) {
       long result = 0;
       foreach (int pile in piles) {
         long hours = (long)Math.Ceiling((double)pile / k);
         result += hours;
       }

       return result;
    }
}
