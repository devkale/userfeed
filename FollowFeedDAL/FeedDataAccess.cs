using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FollowFeedModels;
namespace FollowFeedDAL
{
    public class FeedDataAccess : IFeedDataAccess
    {
        static List<FollowRelation> followRelation = new List<FollowRelation>()
        {
            new FollowRelation() {FolloweeId = "2", FollowerId = "1" },
            new FollowRelation() {FolloweeId = "3", FollowerId = "1" }
        };

        public IEnumerable<Post> GetFeed(string userid)
        {
            var a = from f in followRelation
                    join p in PostDataAccess.posts on f.FolloweeId equals p.UserId
                    where f.FollowerId == userid
                    orderby p.PostsedAt descending
                    select p;
            return a;
        }
    }
}
