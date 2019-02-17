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
    public class FeedController : ApiController
    {
        private IFeedLogic feedlogic;

        FeedController()
        {
            feedlogic = new FeedLogic();
        }

        FeedController(IFeedLogic feedlogic)
        {
           this.feedlogic = feedlogic;
        }
        
        // GET api/feed
        public IHttpActionResult Get()
        {
            // TODO move authentication related code out
            if (!Request.Headers.Contains(Constants.UserId))
            {
                return Unauthorized();
            }

            string userid = Request.Headers.GetValues(Constants.UserId).First();
            return Ok(feedlogic.GetFeed(userid)) ;
        }
    }
}
