namespace MoviesAdmin.Models
{
    public class Movie
    {
        public string MovieId { get; set; } = string.Empty; //For an example of MovieId, let's us Five Nights at Freddy's. It's MovieId could be "FNAF" or if I knew it was a trilogy it could be "FNAF1."
        public int Id { get; set; } //For movies with the same MovieId, this will be how you can differentiate between them.
        public string Title { get; set; } = string.Empty;
        public string ImageFileName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public int NumberRating { get; set; }
        public string Genre { get; set; } = string.Empty;
        public DateTime ReleaseDate { get; set; }
        public string Director { get; set; } = string.Empty;
    }
}
