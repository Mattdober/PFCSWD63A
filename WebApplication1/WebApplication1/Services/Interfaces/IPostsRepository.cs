﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Domain;

namespace WebApplication1.Services.Interfaces
{
    interface IPostsRepository
    {
        void AddPost(Post p);
        Post GetPost(int id);
        void DeletePost(int id);

        IQueryable<Post> GetPosts();
        IQueryable<Post> GetPosts(int blogId);

        void UpdatePost(Post p);
    }
}
