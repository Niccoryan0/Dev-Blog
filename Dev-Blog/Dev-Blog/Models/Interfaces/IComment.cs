﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dev_Blog.Models.Interfaces
{
    public interface IComment
    {
        public Task Create();
    }
}