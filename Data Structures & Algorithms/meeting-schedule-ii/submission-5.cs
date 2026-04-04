/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public int MinMeetingRooms(List<Interval> intervals) {
        if (intervals == null || intervals.Count == 0) return 0;
        intervals.Sort((a, b) => a.start.CompareTo(b.start));

        PriorityQueue<int, int> heap = new();

        for (int i = 0; i < intervals.Count; i++) {
            Interval meeting = intervals[i];
            if (heap.Count > 0 && heap.Peek() <= meeting.start) {
                heap.Dequeue();
            }

            heap.Enqueue(meeting.end, meeting.end);
        }

        return heap.Count;
    }
}
