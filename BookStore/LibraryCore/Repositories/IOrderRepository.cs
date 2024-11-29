using LibraryCore.Models;

namespace LibraryCore.Repositories
{
    public interface IOrderRepository:IGenericRepository<Order>
    {
        public IList<Order> GetOrderByUserId(int userId);
        public int[] CountOrdersByMonth();
        public int[] CountOrdersByDay();


        public IList<Order> GetAllOrdersNav();
    }
}
