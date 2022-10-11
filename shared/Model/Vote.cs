namespace shared.Model
{
    public class Vote 
    {
        public bool Stemmer { get; set; }

        public Vote(bool stemmer)
        {
            this.Stemmer = stemmer;
        }
        public Vote() {

        }
    }
}