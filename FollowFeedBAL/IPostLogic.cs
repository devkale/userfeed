using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FollowFeedModels;

namespace FollowFeedBAL
{
    public interface IPostLogic
    {
        void HandleUserPost(Post post);
        IList<Post> GetAllPosts();
    }
}
