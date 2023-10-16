using MovieStoreWebApi.DBOperations;
using MovieStoreWebApi.Entities;

namespace TestSetup
{
    public static class Orders
    {
        public static void AddOrders(this MovieStoreDbContext context)
        {
            context.Orders.AddRange
            (
                    new Order { CustomerId = 1, MovieId = 1, purchasedTime = new DateTime(2023, 07, 01), IsActive = true },
                    new Order { CustomerId = 2, MovieId = 1, purchasedTime = new DateTime(2023, 06, 01), IsActive = true },
                    new Order { CustomerId = 3, MovieId = 2, purchasedTime = new DateTime(2023, 05, 01), IsActive = true }
             );

        }
    }
}