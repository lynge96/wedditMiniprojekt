namespace Model
{

    public class Comment
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }
        public string Text { get; set; }
        public int Votes { get; set; }
        public long PostId { get; set; }

        public Comment(DateTime date = new DateTime(), User user = null, string text = "", int votes = 0)
        {
            Date = date;
            User = user;
            Text = text;
            Votes = votes;
        }
        public Comment()
        {

        }

    }
}