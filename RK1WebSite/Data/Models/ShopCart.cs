using Microsoft.EntityFrameworkCore;

namespace RK1WebSite.Data.Models
{
    public class ShopCart
    {
        private readonly AppDbContext appDbContext;

        public ShopCart(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public string ShopCartId { get; set; }
        public List<ShopCartItem> Items { get; set; }

        public static ShopCart GetCart(IServiceProvider serviceProvider)
        {
            ISession? session = serviceProvider.GetRequiredService<IHttpContextAccessor>()?.HttpContext?.Session;

            var context = serviceProvider.GetService<AppDbContext>();

            string shopCartId = session?.GetString("CartId") ?? Guid.NewGuid().ToString();

            session?.SetString("CartId", shopCartId);

            return new ShopCart(context)
            {
                ShopCartId = shopCartId,
            };
        }

        public void AddToCart(Car car)
        {
            this.appDbContext.ShopCartItems.Add(new ShopCartItem()
            {
                ShopCartID = ShopCartId,
                Car = car,
                Price = car.Price,
            });

            this.appDbContext.SaveChanges();
        }

        public List<ShopCartItem> GetCartItems()
        {
            return this.appDbContext.ShopCartItems.Where(c => c.ShopCartID == ShopCartId).Include(d => d.Car).ToList();
        }
    }
}
