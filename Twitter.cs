using System.Collections.Generic;

public class Twitter {

    /** Initialize your data structure here. */

    List<Post> m_Post = new List<Post>();
    Dictionary<int, List<int>> follow = new Dictionary<int, List<int>>();
    Dictionary<int, List<Post>> m_UserTweet = new Dictionary<int, List<Post>>();
    
    public Twitter() {

    }
    
    /** Compose a new tweet. */
    public void PostTweet(int userId, int tweetId) {
        if (this.m_UserTweet.ContainsKey(userId)){
            List<Post> post = this.m_UserTweet[userId];
            long time = long.Parse(DateTime.ToFileTime().ToString());
            if (post.Contains(tweetId)){
                post[tweetId].time = time; 
            }
            else{
                Post p = new Post();
                p.time = time;
                p.tweetId = tweetId;
                post.Add(p);
            }
        }
    }
    
    /** Retrieve the 10 most recent tweet ids in the user's news feed. Each item in the news feed must be posted by users who the user followed or by the user herself. Tweets must be ordered from most recent to least recent. */
    public IList<int> GetNewsFeed(int userId) {

    }
    
    /** Follower follows a followee. If the operation is invalid, it should be a no-op. */
    public void Follow(int followerId, int followeeId) {
    }
    
    /** Follower unfollows a followee. If the operation is invalid, it should be a no-op. */
    public void Unfollow(int followerId, int followeeId) {

    }
}

/**
 * Your Twitter object will be instantiated and called as such:
 * Twitter obj = new Twitter();
 * obj.PostTweet(userId,tweetId);
 * IList<int> param_2 = obj.GetNewsFeed(userId);
 * obj.Follow(followerId,followeeId);
 * obj.Unfollow(followerId,followeeId);
 */

 public class Post{

    public int tweetId{get; set;}

    public long time{get; set;}

    public override bool Equals(object obj){
        if(obj == null) return false;
        if ((int)obj != tweetId) return false;
        return true;
    }
 }