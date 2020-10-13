﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dev_Blog.Models.Interfaces
{
    public interface IPost
    {
        /// <summary>
        /// Adds a new post to the database
        /// </summary>
        /// <param name="post">The new post</param>
        /// <param name="url">The url of the image</param>
        /// <returns>New post</returns>
        Task<Post> Create(Post post, string url);

        /// <summary>
        /// Get a list of all posts
        /// </summary>
        /// <returns>Successful result with list of posts</returns>
        Task<List<Post>> GetAllPosts();

        /// <summary>
        /// Gets the most recent post
        /// </summary>
        /// <returns>Most recent post</returns>
        Task<Post> GetLatestPost();

        // TODO: summary comment
        Task<Post> GetCurrentPost(int postId);
    }
}