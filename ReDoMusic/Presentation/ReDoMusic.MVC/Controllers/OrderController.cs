using Microsoft.AspNetCore.Mvc;
using ReDoMusic.Domain.Entities;
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
        public IActionResult Add(String OrderStatus ,DateTime OrderTime ,DateTime DeliveryDate)
        {
            var Order = new Order()
            {
                
                Id = Guid.NewGuid(),
                CreatedOn = DateTime.UtcNow,
            };

            _dbContext.Add(Order);

            _dbContext.SaveChanges();

            return View();
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
