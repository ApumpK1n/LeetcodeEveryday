using System.Collections.Generic;
public class LRUCache {

    private int capacity;
    private List<int> time = new List<int>();
    private Dictionary<int, int> info = new Dictionary<int, int>(); 
    public LRUCache(int capacity) {
        this.capacity = capacity;
    }
    
    public int Get(int key) {
        if (!time.Contains(key)){
            return -1;
        }
        time.Remove(key);
        time.Add(key);
        return info[key];
    }
    
    public void Put(int key, int value) {
        info[key] = value;
        if (time.Count >= capacity && ! time.Contains(key)){
            time.RemoveAt(0);
        }
        if (time.Contains(key)){
            time.Remove(key);
            time.Add(key);

        }
        else{
            time.Add(key);
        }
        
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */