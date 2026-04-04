public class Twitter
{
    private Dictionary<int, HashSet<int>> followMap;
    private Dictionary<int, List<(int tweetId, int time)>> tweetsMap;
    private int time;

    public Twitter()
    {
        followMap = new();
        tweetsMap = new();
        time = 0;
    }

    public void PostTweet(int userId, int tweetId)
    {
        if (!tweetsMap.ContainsKey(userId))
            tweetsMap[userId] = new List<(int, int)>();

        tweetsMap[userId].Add((tweetId, time++));
    }

    public List<int> GetNewsFeed(int userId)
    {
        var feed = new List<int>();
        var heap = new PriorityQueue<(int tweetId, int time), int>();

        if (tweetsMap.ContainsKey(userId))
        {
            foreach (var t in tweetsMap[userId])
                heap.Enqueue(t, -t.time);
        }

        if (followMap.ContainsKey(userId))
        {
            foreach (var followee in followMap[userId])
            {
                if (!tweetsMap.ContainsKey(followee))
                    continue;

                foreach (var t in tweetsMap[followee])
                    heap.Enqueue(t, -t.time);
            }
        }

        while (feed.Count < 10 && heap.Count > 0)
        {
            var tweet = heap.Dequeue();
            feed.Add(tweet.tweetId);
        }

        return feed;
    }

    public void Follow(int followerId, int followeeId)
    {
        if (followerId == followeeId)
            return;

        if (!followMap.ContainsKey(followerId))
            followMap[followerId] = new HashSet<int>();

        followMap[followerId].Add(followeeId);
    }

    public void Unfollow(int followerId, int followeeId)
    {
        if (followMap.ContainsKey(followerId))
            followMap[followerId].Remove(followeeId);
    }
}