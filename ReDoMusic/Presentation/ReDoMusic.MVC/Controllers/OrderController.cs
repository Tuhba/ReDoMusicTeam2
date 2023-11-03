using Microsoft.AspNetCore.Mvc;
using ReDoMusic.Domain.Entities;
using ReDoMusic.Domain.Enums;
using ReDoMusic.Persistence.Contexts;

namespace ReDoMusic.MVC.Controllers
{
    public class OrderController : Controller
    {
        private readonly ReDoMusicDbContext _dbContext;

        public OrderController()
        {
            _dbContext = new();
        }

        [HttpGet]
        public IActionResult Index()
        {
            var orders = _dbContext.Orders.ToList();

            return View(orders);
        }

        [HttpGet]
        public IActionResult AddOrder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddOrder(string instrumentId, DateTime OrderDate, DateTime DeliveryDate)
        {
                var order = new Order
                {
                    Instrument = _dbContext.Instruments.Where(x => x.Id == Guid.Parse(instrumentId)).FirstOrDefault(),  
                    OrderStatus = OrderStatus.routed,
                    OrderDate = DateTime.UtcNow,
                    DeliveryDate = DateTime.UtcNow,
                    CreatedOn = DateTime.UtcNow
                };

                _dbContext.Orders.Add(order);
                _dbContext.SaveChanges();

                return RedirectToAction("Index");
        }


        [Route("[controller]/[action]/{id}")]
        public IActionResult Delete(string id)
        {
            var order = _dbContext.Orders.Where(x => x.Id == Guid.Parse(id)).FirstOrDefault();

            _dbContext.Orders.Remove(order);

            _dbContext.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
