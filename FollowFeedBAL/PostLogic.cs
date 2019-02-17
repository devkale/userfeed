using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FollowFeedModels;
using FollowFeedDAL;

namespace FollowFeedBAL
{
    public class PostLogic : IPostLogic
    {
        IPostDataAccess postdataAccess;

        public PostLogic()
        {
            postdataAccess = new PostDataAccess();
        }
        public IList<Post> GetAllPosts()
        {
            return postdataAccess.GetPosts();
        }

        public void HandleUserPost(Post post)
        {
            postdataAccess.SaveUserPost(post);
        }


    }
}
