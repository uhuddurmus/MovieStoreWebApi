using Microsoft.EntityFrameworkCore;
using MovieStoreWebApi.Entities;

namespace MovieStoreWebApi.DBOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MovieStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<MovieStoreDbContext>>()))
            {
                context.Customers.AddRange(
                    new Customer { FirstName = "Uhud", LastName = "Durmus", Email = "uhud@mail.com", Password = "111111", RefreshToken = "" },
                    new Customer { FirstName = "Uhud1", LastName = "Durmus1", Email = "uhud2@mail.com", Password = "111111", RefreshToken = "" },
                    new Customer { FirstName = "Uhud2", LastName = "Durmus2", Email = "uhud3@mail.com", Password = "111111", RefreshToken = "" }
                );

                context.Movies.AddRange(
                    new Movie { Title = "Yüzüklerin Efendisi: Yüzük Kardeşliği", Release_year = "2001", CategoryId = 1, Price = 100 },
                    new Movie { Title = "Yüzüklerin Efendisi: İki Kule", Release_year = "2002", CategoryId = 1, Price = 120 },
                    new Movie { Title = "Yüzüklerin Efendisi: Kralın Dönüşü", Release_year = "2003", CategoryId = 1, Price = 140 }
                );

                context.Actors.AddRange(
                    new Actor { FirstName = "Elijah", LastName = "Wood" },
                    new Actor { FirstName = "Ian", LastName = "McKellen" },
                    new Actor { FirstName = "Viggo", LastName = "Mortensen" },
                    new Actor { FirstName = "Sean", LastName = "Astin" },
                    new Actor { FirstName = "Peter", LastName = "Jackson" },
                    new Actor { FirstName = "Orlando", LastName = "Bloom" },
                    new Actor { FirstName = "Cate", LastName = "Blanchett" }
                );

                context.Directors.AddRange(
                    new Director { FirstName = "Peter", LastName = "Jackson" }
                );

                context.Categories.AddRange(
                    new Category { CategoryName = "Fantastik" }
                );

                context.MovieActors.AddRange(
                    new MovieActor { ActorId = 1, MovieId = 1 },
                    new MovieActor { ActorId = 2, MovieId = 1 },
                    new MovieActor { ActorId = 3, MovieId = 1 },
                    new MovieActor { ActorId = 4, MovieId = 2 },
                    new MovieActor { ActorId = 5, MovieId = 2 },
                    new MovieActor { ActorId = 6, MovieId = 2 },
                    new MovieActor { ActorId = 7, MovieId = 3 }
                );

                context.MovieDirectors.AddRange(
                    new MovieDirector { MovieId = 1, DirectorId = 1 },
                    new MovieDirector { MovieId = 2, DirectorId = 1 },
                    new MovieDirector { MovieId = 3, DirectorId = 1 }
                );

                context.Orders.AddRange(
                    new Order { CustomerId = 1, MovieId = 1, purchasedTime = new DateTime(2023, 07, 01), IsActive = true },
                    new Order { CustomerId = 2, MovieId = 1, purchasedTime = new DateTime(2023, 06, 01), IsActive = true },
                    new Order { CustomerId = 3, MovieId = 2, purchasedTime = new DateTime(2023, 05, 01), IsActive = true }
                );

                context.CustomerCategories.AddRange(
                    new CustomerCategory { CustomerId = 1, CategoryId = 1 },
                    new CustomerCategory { CustomerId = 1, CategoryId = 2 },
                    new CustomerCategory { CustomerId = 1, CategoryId = 3 },
                    new CustomerCategory { CustomerId = 2, CategoryId = 2 },
                    new CustomerCategory { CustomerId = 2, CategoryId = 3 },
                    new CustomerCategory { CustomerId = 3, CategoryId = 1 }
                );

                context.SaveChanges();
            }
        }
    }
}
