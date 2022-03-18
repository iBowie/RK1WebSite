using RK1WebSite.Data.Interfaces;
using RK1WebSite.Data.Models;

namespace RK1WebSite.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDbContext appDbContext;
        private readonly ShopCart shopCart;

        public OrdersRepository(AppDbContext appDbContext, ShopCart shopCart)
        {
            this.appDbContext = appDbContext;
            this.shopCart = shopCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;

            appDbContext.Orders.Add(order);

            appDbContext.SaveChanges();

            var items = shopCart.Items;

            foreach (var item in items)
            {
                OrderDetail orderDetail = new()
                {
                    CarID = item.Car.ID,
                    OrderID = order.ID,
                    Price = item.Car.Price,
                };

                appDbContext.OrderDetails.Add(orderDetail);
            }

            appDbContext.SaveChanges();
        }
    }
}
