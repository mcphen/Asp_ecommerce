using ProjectCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCore.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }


        public void CreateOrder(Order order)
        {
            order.OrderCreateDate = DateTime.Now;
            var items = _shoppingCart.GetShoppingCartItems(); 
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();
            order.OrderDetails = new List<OrderDetail>();
            foreach(var book in items)
            {
                var OrderDetail = new OrderDetail
                {
                    BookId = book.book.BookId,
                    Amount = book.Amount,
                    Price = book.book.Price


                };
                order.OrderDetails.Add(OrderDetail);
            }
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();
           // throw new NotImplementedException();
        }
    }
}
