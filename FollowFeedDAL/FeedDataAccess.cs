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

        public IList<Post> GetFeed(string userid)
        {
                
        }
    }
}
