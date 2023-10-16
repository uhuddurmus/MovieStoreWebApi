using MovieStoreWebApi.DBOperations;
using MovieStoreWebApi.Entities;

namespace TestSetup
{
    public static class Actors
    {
        public static void AddActors(this MovieStoreDbContext context)
        {
              context.Actors.AddRange(
                    new Actor { FirstName = "Elijah", LastName = "Wood" },
                    new Actor { FirstName = "Ian", LastName = "McKellen" },
                    new Actor { FirstName = "Viggo", LastName = "Mortensen" },
                    new Actor { FirstName = "Sean", LastName = "Astin" },
                    new Actor { FirstName = "Peter", LastName = "Jackson" },
                    new Actor { FirstName = "Orlando", LastName = "Bloom" },
                    new Actor { FirstName = "Cate", LastName = "Blanchett" }
                );
        }
    }
}