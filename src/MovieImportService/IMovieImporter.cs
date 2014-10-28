using System.Collections.Generic;

namespace MovieImportService
{
    public interface IMovieImporter
    {
        IEnumerable<Movie> ImportMovies();
    }
}