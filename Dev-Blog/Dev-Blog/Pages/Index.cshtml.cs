﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Dev_Blog.Models;
using Dev_Blog.Models.Base;
using Dev_Blog.Models.Interfaces;
using Dev_Blog.Models.ViewModels;
using Dev_Blog.Pages.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Dev_Blog.Pages
{
    public class IndexModel : BasePage
    {
        private readonly IPost _post;

        [BindProperty]
        public Post Post { get; set; }

        public IndexModel(SignInManager<User> signInManager, UserManager<User> userManager, IPost post) : base(signInManager, userManager)
        {
            _post = post;
        }

        public async Task<IActionResult> OnGet()
        {
            Post = await _post.GetLatestPost();

            return Page();
        }
    }
}