namespace shared.Model
{
    public class Post
    {
        public int PostId { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public User User { get; set; }
        public int Votes { get; set; }
        public string Text { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post(DateTime date = new DateTime(), string title = "", User user = null, int votes = 0, string text = "")
        {
            Date = date;
            Title = title;
            User = user;
            Votes = votes;
            Text = text;
        }

        public Post()
        {

        }

    }
}