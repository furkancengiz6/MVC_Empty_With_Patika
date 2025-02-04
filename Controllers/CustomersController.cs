using Microsoft.AspNetCore.Mvc;
using MVC_Empty_With_Patika.Models;

namespace MVC_Empty_With_Patika.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Ali",
                LastName = "Akın",
                Email = "ali.akın@example.com"
            };

            var viewModel = new CustomerViewModel
            {
                customer = customer,
                WelcomeMessage = "Welcome to the Customers Page"
            };
            return View(viewModel);
        }
    }
}
