using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using shared.Model;

namespace Data
{
    public class PostContext : DbContext
    {
        public DbSet<Post> Posts => Set<Post>();
        public DbSet<Comment> Comments => Set<Comment>();
        public DbSet<User> Users => Set<User>();


        public PostContext (DbContextOptions<PostContext> options)
            : base(options)
        {
            // Den her er tom. Men ": base(options)" sikre at constructor
            // på DbContext super-klassen bliver kaldt.
        }
    }
}