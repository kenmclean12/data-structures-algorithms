public class LRUCache {
    private int capacity;
    private Dictionary<int, LinkedListNode<(int key, int value)>> cache;
    private LinkedList<(int key, int value)> list;
    
    public LRUCache(int capacity) {
       this.capacity = capacity;
       cache = new();
       list = new();
    }
    
    public int Get(int key) {
        if (!cache.ContainsKey(key)) return -1;
        var item = cache[key];
        list.Remove(item);
        list.AddFirst(item);

        return item.Value.value;
    }
    
    public void Put(int key, int value) {
        if (cache.ContainsKey(key)) {
            var item = cache[key];
            list.Remove(item);
            item.Value = (key, value);
            list.AddFirst(item);
        } else {
            if (cache.Count >= capacity) {
                var last = list.Last;
                cache.Remove(last.Value.key);
                list.Remove(last);
            }

            var node = new LinkedListNode<(int, int)>((key, value));
            cache[key] = node;
            list.AddFirst(node);
        }
    }
}
