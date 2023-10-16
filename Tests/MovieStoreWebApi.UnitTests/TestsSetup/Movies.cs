using MovieStoreWebApi.DBOperations;
using MovieStoreWebApi.Entities;

namespace TestSetup
{
    public static class Movies
    {
        public static void AddMovies(this MovieStoreDbContext context)
        {
            context.Movies.AddRange
            (
                    new Movie { Title = "Yüzüklerin Efendisi: Yüzük Kardeşliği", Release_year = "2001", CategoryId = 1, Price = 100 },
                    new Movie { Title = "Yüzüklerin Efendisi: İki Kule", Release_year = "2002", CategoryId = 1, Price = 120 },
                    new Movie { Title = "Yüzüklerin Efendisi: Kralın Dönüşü", Release_year = "2003", CategoryId = 1, Price = 140 }
             );

        }
    }
}