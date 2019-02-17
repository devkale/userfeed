using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FollowFeedModels;

namespace FollowFeedDAL
{
    public interface IPostDataAccess
    {
        void SaveUserPost(Post post);

        IList<Post> GetPosts();
    }
}
