namespace Model
{

    public class User
    {
        public long Id { get; set; }
        public string Username { get; set; }

        public User(string username = "")
        {
            Username = username;
        }

        public User()
        {

        }
    }
}