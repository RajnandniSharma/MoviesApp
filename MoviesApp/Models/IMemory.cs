namespace MoviesApp.Models
{
    public class IMemory
    {
        List<Movies> Movies = new List<Movies>()
        {
            new Movies(){Id=1,Title="DDLJ",Description="The best Movies of SRK",Rating = 10},
            new Movies(){Id=2,Title="PK",Description="The best Movies of Aamir",Rating = 10},
            new Movies(){Id=3,Title="Ready",Description="The best Movies of Salman",Rating = 10},
        };

        public List<Movies> getAllMovies()
        {
            return Movies;
        }
    }
}
