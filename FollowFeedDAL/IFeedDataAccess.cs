﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FollowFeedModels;
namespace FollowFeedDAL
{
    public interface IFeedDataAccess
    {
        IList<Post> GetFeed(string userid);
    }
}