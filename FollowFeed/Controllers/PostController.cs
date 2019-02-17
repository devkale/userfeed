using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FollowFeedModels;
using FollowFeedBAL;

namespace FollowFeed.Controllers
{
    
    public class PostController : ApiController
    {
        private IPostLogic postlogic;

        PostController()
        {
            //if (this.postlogic != null)
            //{
            this.postlogic = new PostLogic();
            //}
        }

        PostController(IPostLogic postlogic)
        {
            this.postlogic = postlogic;          
        }
         
        // POST api/post
        public IHttpActionResult Post([FromBody]Post post)
        {
            // TODO move authentication related code out
            if(!Request.Headers.Contains(Constants.UserId))
            {
                return Unauthorized();
            }

            Post persistentpost = new Post();
            post.UserId = Request.Headers.GetValues(Constants.UserId).First();
            post.Content = post.Content;
            post.PostsedAt = DateTime.UtcNow;
            // persist
            postlogic.HandleUserPost(post);
            return ResponseMessage(new HttpResponseMessage(HttpStatusCode.Created));
        }

        // GET /api/post
        public IEnumerable<Post> Get()
        {
            return postlogic.GetAllPosts();
        }
    }
}
