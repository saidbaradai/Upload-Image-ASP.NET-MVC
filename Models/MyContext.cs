﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Upload_Image_v2.Models
{
    public class MyContext:DbContext
    {
        public DbSet<Image> Images { get; set; }

    }
}