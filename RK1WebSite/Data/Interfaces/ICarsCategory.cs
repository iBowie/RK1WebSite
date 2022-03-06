using RK1WebSite.Data.Models;

namespace RK1WebSite.Data.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
