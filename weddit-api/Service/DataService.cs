
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

            db.SaveChanges();

            Comment comment = db.Comments.FirstOrDefault()!;
            if (comment == null)
            {
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Kim"), Text = "Du er lort", PostId = 1 });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Tina"), Text = "Du er nice", PostId = 2 });
            }

            db.SaveChanges();
        }

        // Hent alle posts til forsiden
        public List<Post> GetPosts()
        {
            return db.Posts.Include(x => x.User).Include(x => x.Comments).ToList();
        }

        // Hent en specifik post
        public Post GetPost(int postId)
        {
            Post post = db.Posts.Include(x => x.User).Include(x => x.Comments).Where(x => x.PostId == postId).First();

            List<Comment> kommentarer = db.Comments.Include(x => x.User).Where(x => x.PostId == postId).ToList();

            post.Comments = kommentarer;

            return post;
        }

        // Tilføjer en kommentar
        public void AddComment(Comment newComment)
        {
            db.Comments.Add(new Comment { Date = DateTime.Now, User = newComment.User, Text = newComment.Text, PostId = newComment.PostId});

            db.SaveChanges();
        }

        // Tilføjer en stemme til en kommentar
        public string AddVotePost(int postId, bool vote)
        {
            if (vote == true)
            {
                Post post = db.Posts.Where(x => x.PostId == postId).First();

                post.Votes++;
            }
            else if (vote == false)
            {
                Post post = db.Posts.Where(x => x.PostId == postId).First();

                post.Votes--;
            }

            db.SaveChanges();

            return "Vote added";

        }

        // Tilføjer en post
        public void AddPost(Post newPost)
        {
            db.Post.Add(new Post { Date = DateTime.Now, Title = newPost.Title, Text = newPost.Text, User = newPost.User });

            db.SaveChanges();
        }

    }

}


