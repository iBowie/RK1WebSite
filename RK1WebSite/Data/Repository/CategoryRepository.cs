using RK1WebSite.Data.Interfaces;
using RK1WebSite.Data.Models;

namespace RK1WebSite.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDbContext appDbContent;

        public CategoryRepository(AppDbContext appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public IEnumerable<Category> AllCategories
        {
            get
            {
                return appDbContent.Categories;
            }
        }
    }
}
