
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using Data;
using shared.Model;
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
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "To læk på Nordstream 1", User = new User("Lars"), Text = "Der er sgu gået hul på noget, OBS: ik sejl over, I synker!!!", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "Hvorfor er bajer godt for dig?", User = new User("Katrine"), Text = "Det er fordi, at de smager pisse godt, og så kan det godt være, at du får det dårligt i et stykke tid efter, men det er worth", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "Det absolut billigste kollegieværelse på nyt kollegie i njalsgade, Amager er 7.500 kr/md for 28m² uden sollys.", User = new User("Thomas"), Text = "i.imgur.com/7zVxBCK.jpg", TextIsLink = true });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "Poor Danish familie can't afford car and have have to bike to get around, 2022", User = new User("Morten"), Text = "i.imgur.com/eUjfcre.jpg", TextIsLink = true });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "Svært valg", User = new User("Abinash"), Text = "i.imgur.com/B8eCaxm.jpg", TextIsLink = true });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "Hvordan holder i frokosten på arbejdet ud?", User = new User("Denis"), Text = "Hej scootergalleri\nJeg har et problem (first world problem x10000) som jeg håber andre også har (haft) og dermed kan hjælpe mig til hvad hulan jeg gør.\nJeg hader frokostpausen på mit arbejde. Lige siden jeg indtrådte på arbejdsmarkedet efter endt uddannelse har jeg hadet frokostpausen. Hele seancen i minutterne op til middag hvor folk på skift råber \"nååå det er vel ved at være tid\" til at sidde og småsnakke med mine kollegaer om komplet ligegyldige ting mens jeg indtager den tvivlsomme omgang mad jeg har fået blandet på min tallerken i buffeten. Det er det samme i alle 3 virksomheder jeg nu har været i og jeg hader det.\nMisforstå mig ikke, jeg hader ikke mine kollegaer. De er flinke og jeg kan også sagtens deltage i snakken henover skrivebordet. Men i frokostpausen slapper jeg simpelthen ikke af i de 30 minutter der egentlig er tiltænkt til netop det. Hvis jeg kan finde den mindste undskyldning for lige at køre ud og \"ordne\" noget i frokostpausen så gør jeg det. De der 20-25 minutter i bilen for mig selv er himmelske.\nSå mit spørgsmål: Er der andre som har det på samme måde som mig? Og som har fundet en måde at håndtere det på? Jeg overvejer at gå til chefen med mine bekymringer men jeg er bange for at det bliver set som en utrolig negativ ting at jeg ikke vil bruge tid med mine kollegaer.", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "Min roomie kommer ketchup på ALT", User = new User("Anna"), Text = "Altså jeg ved ikke, om det er noget, som I kan relatere til, men er det seriøst normalt at der skal ketchup på alt? Har prøvet at sige til dem, at det ikke er almindeligt, men de køber den ikke!!!", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "Min yndlings pizza er hawaii", User = new User("Victor"), Text = "- sagde en psykopat engang, LOL", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "JONAS Fucking VINGEGAARD", User = new User("Tobias"), Text = "i.redd.it/r2o9rvs675e91.png", TextIsLink = true });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Kasper"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Mette Kirstine"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Wiliam"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Sebastian"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Mikkel"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Allan"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Mathias"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Frederik"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Jakob"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Tina"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Gunner"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Lucca"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Bent"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Bo"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Børge"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Pernille"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Maria"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Mohammed"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Burat"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Mahmoud"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Ella"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Ali"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Tony"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Christian"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Ane"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Cecilie"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Lisbeth"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Hans"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Amanda"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Sisse"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Magnus"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Jonas"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Patrick"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Sofie"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Olivia"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Stine"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Mikki"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("John"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Rasmus"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Alberte"), Text = "", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "", User = new User("Klara"), Text = "", TextIsLink = false });
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
        public string AddComment(Comment newComment)
        {
            db.Comments.Add(new Comment { Date = DateTime.Now, User = newComment.User, Text = newComment.Text, PostId = newComment.PostId});

            db.SaveChanges();

            return "New comment added";
        }

        // Tilføjer en post
        public string AddPost(Post newPost)
        {
            db.Posts.Add(new Post { Date = DateTime.Now, Title = newPost.Title, Text = newPost.Text, User = newPost.User, TextIsLink = newPost.TextIsLink });

            db.SaveChanges();

            return "New post added";
        }

        // Tilføjer en stemme til en post
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

        // Tilføjer en stemme til en kommentar
        public string AddVoteComment(int commentId, bool vote)
        {
            if (vote == true)
            {
                Comment comment = db.Comments.Where(x => x.CommentId == commentId).First();

                comment.Votes++;
            }
            else if (vote == false)
            {
                Comment comment = db.Comments.Where(x => x.CommentId == commentId).First();

                comment.Votes--;
            }

            db.SaveChanges();

            return "Vote added";
        }


    }

}


