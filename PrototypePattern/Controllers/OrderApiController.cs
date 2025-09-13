using Microsoft.AspNetCore.Mvc;
using PrototypePattern.Models;
using PrototypePattern.Services;

namespace PrototypePattern.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class OrderApiController : ControllerBase
  {
    private UserService userService = new UserService();
    private OrderService orderService = new OrderService();

    // GET: api/OrderApi/1
    [HttpGet("{id}")]
    public ActionResult<object> Get(int id)
    {
      var mainOrder = orderService.GetOrderById(id);
      if (mainOrder == null) return NotFound();
      var subOrder = mainOrder.Clone();
      subOrder.Status = "Chờ xác nhận";
      var mainReport = new Report
      {
        ReportType = "Main Report",
        OrderDetails = mainOrder,
        UserName = userService.GetUserName(id)
      };

      var subReport = new Report
      {
        ReportType = "Sub Report",
        OrderDetails = subOrder,
        UserName = ""
      };

      return Ok(new { MainReport = mainReport, SubReport = subReport });
    }
  }
}
