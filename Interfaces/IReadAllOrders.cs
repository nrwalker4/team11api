using team11api.Models;

namespace team11api.Interfaces
{
    public interface IReadAllOrders
    {
         public List<Order> GetAllOrders();
    }
}