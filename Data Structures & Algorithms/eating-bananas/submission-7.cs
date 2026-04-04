public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
       int left = 1;
       int right = 0;

       foreach (int pile in piles) {
          right = Math.Max(right, pile);
       }

       while (left < right) {
          int mid = left + (right - left) / 2;
          if (HoursNeeded(piles, mid) > h) {
            left = mid + 1;
          } else {
            right = mid;
          }
       }

       return left;
    }

    private int HoursNeeded(int[] piles, int k) {
        int hours = 0;

        foreach (int pile in piles) {
            hours += (int)Math.Ceiling((double)pile / k);
        }

        return hours;
    }
}
