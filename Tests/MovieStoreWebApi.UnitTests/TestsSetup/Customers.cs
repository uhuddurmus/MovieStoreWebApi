using MovieStoreWebApi.DBOperations;
using MovieStoreWebApi.Entities;

namespace TestSetup
{
    public static class Customers
    {
        public static void AddCustomers(this MovieStoreDbContext context)
        {
                context.Customers.AddRange(
                    new Customer { FirstName = "Uhud", LastName = "Durmus", Email = "uhud@mail.com", Password = "111111", RefreshToken = "" },
                    new Customer { FirstName = "Uhud1", LastName = "Durmus1", Email = "uhud2@mail.com", Password = "111111", RefreshToken = "" },
                    new Customer { FirstName = "Uhud2", LastName = "Durmus2", Email = "uhud3@mail.com", Password = "111111", RefreshToken = "" }

                );
        }
    }
}