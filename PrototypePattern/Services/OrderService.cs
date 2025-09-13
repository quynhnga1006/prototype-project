using PrototypePattern.Models;
namespace PrototypePattern.Services
{
    public class OrderService
    {
        public Order GetOrderById(int id)
        {
            return new Models.Order(id, "Sample Product", 1, 99.99m, "Đã chuyển hàng");
        }
    }
}