using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FollowFeedModels;
namespace FollowFeedBAL
{
    public interface IFeedLogic
    {
        IEnumerable<Post> GetFeed(string userid);
    }
}
