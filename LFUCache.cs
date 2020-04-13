using System.Collections.Generic;

public class LFUCache {

    private Dictionary<int, int> Value = new Dictionary<int, int>();
    private List<int> KeySort = new List<int>();
    private int MaxCount;
    public LFUCache(int capacity) {
        this.MaxCount = capacity;
    }
    
    public void RecordKey(int key){
        if (!Value.ContainsKey(key)) return;
        if (KeySort.Contains(key)){
            KeySort.Remove(key);
        }
        KeySort.Add(key);
    }

    public int Get(int key) {
        if(Value.ContainsKey(key)){

        }
        return -1;
    }
    
    public void Put(int key, int value) {

    }
}

/**
 * Your LFUCache object will be instantiated and called as such:
 * LFUCache obj = new LFUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */