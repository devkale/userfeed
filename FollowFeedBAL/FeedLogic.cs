﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FollowFeedModels;
using FollowFeedDAL;

namespace FollowFeedBAL
{
    public class FeedLogic : IFeedLogic
    {
        IFeedDataAccess feeddataAccess;

        public FeedLogic()
        {
            this.feeddataAccess = new FeedDataAccess();
        }
        public IEnumerable<Post> GetFeed(string userid)
        {
            return feeddataAccess.GetFeed(userid);
        }
    }
}
