using ordering_and_sales_system.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ordering_and_sales_system.Models;
using System.Text.Json;
using ordering_and_sales_system.Domain.Entities;
using ordering_and_sales_system.Domain.Repositories;    


namespace ordering_and_sales_system.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Inventory()
        {
            return View();
        }

        public IActionResult PendingOrders()
        {
            return View();
        }

        [HttpGet]
            public IActionResult TransactionHistory()
            {
                TransactionHistoryService transactionHistoryService = new TransactionHistoryService();
                TransactionHistoryModel transactionHistoryModel = transactionHistoryService.Model;
                transactionHistoryService.Dispose();

                return View(transactionHistoryModel);
            }

        public IActionResult Customer()
        {
            CustomerService customerService = new CustomerService();
            CustomerModel customerModel = customerService.GetAllCustomerList();
            customerService.Dispose();

            return View(customerModel);
        }

        public IActionResult AddCustomer([FromBody] ICustomers customerData)
        {
            // Access service and then send the customerData into the AddCustomer function
            // Terminate connection
            CustomerService customerService = new CustomerService();
            customerService.AddCustomer(customerData);
            customerService.Dispose();

            return Ok("Success");
        }

        public IActionResult OrderReport()
        {
            return View();
        }

        public IActionResult SalesReport()
        {
            return View();
        }

        public IActionResult SignOut()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}