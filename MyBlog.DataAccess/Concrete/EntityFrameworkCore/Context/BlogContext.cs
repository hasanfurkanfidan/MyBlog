﻿using Microsoft.EntityFrameworkCore;
using MyBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.DataAccess.Concrete.EntityFrameworkCore.Context
{
   public class BlogContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-3VB3SSC\\MSSQLSERVERLAST;database=MyBlog;integrated security=true");
        }
        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<CategoryBlog> CategoryBlogs { get; set; }

        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<Comment> Comments { get; set; }


    }
}
