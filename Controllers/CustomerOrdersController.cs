using Microsoft.AspNetCore.Mvc;
using PatikaBasicMVCTask.Models;

namespace PatikaBasicMVCTask.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {


            Customer customer = new Customer()
            {
                CustomerID = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com"
            };

            Order order1 = new Order()
            {
                Id = 1,
                Price = 1000,
                ProductName = "Phone",
                Quantity = 1,
            };

            Order order2 = new Order()
            {
                Id = 2,
                Price = 1300,
                ProductName = "PC",
                Quantity = 1,
            };

            CustomerOrderViewModel customerOrderViewModel = new CustomerOrderViewModel()
            {
                Customer = customer,
                Orders = new List<Order> {
            order1, order2
            }
            };



            return View(customerOrderViewModel);
        }
    }
}
