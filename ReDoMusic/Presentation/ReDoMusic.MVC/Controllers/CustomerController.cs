using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ReDoMusic.Domain.Entities;
using ReDoMusic.Persistence.Contexts;

namespace ReDoMusic.MVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ReDoMusicDbContext _dbContext;
        private object _dbcontext;


        public CustomerController()
        {
            _dbContext = new();
        }

        [HttpGet]
        public IActionResult Index()
        {
            var customers = _dbContext.Customers.ToList();

            return View(customers);
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(string firstName, string lastName, string email, string address)
        {
            var customer = new Customer()
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Address = address,
                Id = Guid.NewGuid(),
                CreatedOn = DateTime.UtcNow,
            };

            _dbContext.Customers.Add(customer);

            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [Route("[controller]/[action]/{id}")]
        public IActionResult Delete(string id)
        {
            var customer = _dbContext.Customers.Where(x => x.Id == Guid.Parse(id)).FirstOrDefault();

            _dbContext.Customers.Remove(customer);

            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}