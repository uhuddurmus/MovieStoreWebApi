using MovieStoreWebApi.DBOperations;
using MovieStoreWebApi.Entities;

namespace TestSetup
{
    public static class Categories
    {
        public static void AddCategories(this MovieStoreDbContext context)
        {
                context.Categories.AddRange(
                    new Category { CategoryName = "Fantastik" }
                );
        }
    }
}