using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FollowFeedModels;

namespace FollowFeedDAL
{
    public class PostDataAccess : IPostDataAccess
    {
        public static List<Post> posts = new List<Post>();

        public IList<Post> GetPosts()
        {
            return posts;
        }

        public void SaveUserPost(Post post)
        {
            posts.Add(post);
        }
    }
}
