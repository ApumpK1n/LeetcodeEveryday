// 水壶问题
//深度优先搜索

using System.Collections.Generic;
using System.Collections;

public class Solution {
    public bool CanMeasureWater(int x, int y, int z) {
        if (z == 0) return true;
        if (x + y < z) return false;
        HashSet<WaterState> State = new HashSet<WaterState>();
        Queue<WaterState> Handle = new Queue<WaterState>();
        WaterState water = new WaterState(0, 0);
        Handle.Enqueue(water);
        State.Add(water);
        while(Handle.Count > 0 ){
            WaterState nowWater = Handle.Dequeue();
            int remain_x = nowWater.x;
            int remain_y = nowWater.y;
            if (remain_x + remain_y == z || remain_x == z || remain_y == z) return true;
            // foreach(WaterState ret in State){
            //     if (ret.x == nowWater.x && ret.y == nowWater.y) continue;
            // }
            
            //State.Add(nowWater);
            // 第一个水壶装满
            AddState(new WaterState(x, remain_y), State, Handle);
            // 第二个水壶装满
            AddState(new WaterState(remain_x, y), State, Handle);
            // 第一个水壶倒空
            AddState(new WaterState(0, remain_y), State, Handle);
            // 第二个水壶倒空
            AddState(new WaterState(remain_x, 0), State, Handle);
            // 从第一个水壶向第二个水壶倒水，直到装满或者倒空
            int CanMove = Math.Min(remain_x, y - remain_y);
            AddState(new WaterState(remain_x - CanMove, remain_y + CanMove), State, Handle);
            // 从第二个水壶向第一个水壶倒水，直到装满或者倒空
            CanMove = Math.Min(remain_y, x - remain_x);
            AddState(new WaterState(remain_x + CanMove, remain_y - CanMove), State, Handle);
        }
        return false;
    }

    public void AddState(WaterState water, HashSet<WaterState> State, Queue<WaterState> Handle){
        bool flag = false;
        foreach(WaterState ret in State){
            if (ret.x == water.x && ret.y == water.y) flag = false;
            else flag = true;
        }
        if (flag){
            State.Add(water);
            Handle.Enqueue(water);
        }
    }

    public class WaterState{
        
        public int x;
        public int y;
        public WaterState(int x, int y){
            this.x = x;
            this.y = y;
        }
    }
}