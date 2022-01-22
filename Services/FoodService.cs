using Template.Data;
using Template.Infrastucture;
using Template.Models;

namespace Template.Services
{
    public class FoodService : RepositoryService<Food> ,IFood
    {
        public FoodService(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
}
