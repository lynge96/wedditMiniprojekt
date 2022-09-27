using Microsoft.EntityFrameworkCore;
using Model;

namespace Data
{
    public class ThreadContext : DbContext
    {
        public DbSet<Thread> Threads => Set<Thread>();
        public DbSet<Comment> Comments => Set<Comment>();
        public DbSet<User> Users => Set<User>();


        public ThreadContext (DbContextOptions<ThreadContext> options)
            : base(options)
        {
            // Den her er tom. Men ": base(options)" sikre at constructor
            // på DbContext super-klassen bliver kaldt.
        }
    }
}