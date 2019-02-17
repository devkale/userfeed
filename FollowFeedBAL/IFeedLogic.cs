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
        IList<Post> GetFeed(string userid);
    }
}
