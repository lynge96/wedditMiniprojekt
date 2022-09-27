
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using Data;
using Model;
using System;

namespace weddit_api.Service
{
    public class DataService
    {
        private PostContext db { get; }

        public DataService(PostContext db)
        {
            this.db = db;
        }

        /// <summary>
        /// Seeder noget nyt data i databasen hvis det er nødvendigt.
        /// </summary>
        public void SeedData()
        {
            User user = db.Users.FirstOrDefault()!;
            if (user == null)
            {
                db.Users.Add(new User("Jacob"));
                db.Users.Add(new User("Anders"));
            }

            Post post = db.Posts.FirstOrDefault()!;
            if (post == null)
            {
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "To læk på Nordstream 1", User = new User("Lars"), Text = "Der er sgu gået hul på noget, OBS: ik sejl over, I synker!!!" });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "When your parents get divorces, so he's no longer your stepbrother", User = new User("Niels"), Text = "INDSÆT LINK" });
            }

            Comment comment = db.Comments.FirstOrDefault()!;
            if (comment == null)
            {
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Kim"), Text = "Du er lort", PostId = 1});
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Tina"), Text = "Du er nice", PostId = 2});
            }

            db.SaveChanges();
        }

    }
}

