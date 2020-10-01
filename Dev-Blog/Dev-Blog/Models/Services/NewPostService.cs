﻿using Dev_Blog.Data;
using Dev_Blog.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Dev_Blog.Models.Services
{
    public class NewPostService : INewPost
    {
        private DevBlogDbContext _context;

        public NewPostService(DevBlogDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Adds a new post to the database
        /// </summary>
        /// <param name="post">The new post</param>
        /// <param name="imgName">Name of the image being uploaded</param>
        /// <returns>New post</returns>
        public async Task<NewPost> Create(NewPost post, string imgName)
        {
            string url = $"https://thedevblog.blob.core.windows.net/pictures/{imgName}";

            post.ImgURL = url;
            post.Date = DateTime.Now;

            _context.Entry(post).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return post;
        }
    }
}