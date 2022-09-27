namespace Model
{
    public class Thread {
        public long ThreadId { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public User User { get; set; }
        public int Votes { get; set; }
        public string Text { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Thread(DateTime date = DateTime.now, string title = "", User user = new User { Username = "" }, int votes = 0, string text = "") {
            Date = date;
            Title = title;
            User = user;
            Votes = votes;
            Text = text;
        }

        public Thread() {

        }

    }
}