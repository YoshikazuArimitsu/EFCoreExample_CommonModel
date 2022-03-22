using CommonModelLib.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonModelLib.Context
{
    public class CommonDbContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        #region .ctor
        /// <summary>
        /// .ctor
        /// </summary>
        public CommonDbContext()
        {

        }

        public CommonDbContext(DbContextOptions<CommonDbContext> options)
            : base(options)
        {
        }
        #endregion

    }
}
