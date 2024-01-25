using ordering_and_sales_system.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ordering_and_sales_system.Models;
using System.Text.Json;
using ordering_and_sales_system.Domain.Entities;
using ordering_and_sales_system.Domain.DataTransferObject;

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
            InventoryService inventoryService = new InventoryService();
            InventoryModel inventoryModel = inventoryService.GetAllInventoryList();
            inventoryService.Dispose();

            return View(inventoryModel);
        }

        public IActionResult PendingOrders()
        {
            return View();
        }

     
       /* public IActionResult GetPendingOrdersDataList()
        {
            PendingOrdersService pendingOrdersService = new PendingOrdersService();
            List<PendingOrders> pendingOrdersList = new List<PendingOrders>();

            foreach (PendingOrdersDataTransferObject pendingOrders in pendingOrdersService.Model.PendingOrdersList!)
            {
                pendingOrdersList.Add(new PendingOrders(pendingOrders));
            }
            List<Customers> customerList = pendingOrdersService.Model.CustomerList!;

            var result = new
            {
                Products = productList,
                Customers = customerList
            };

            return Ok(result);
        }*/

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

        public IActionResult AddCustomer([FromBody] Customers customerData)
        {

            /*Debug.WriteLine("Here");
            Debug.WriteLine(JsonSerializer.Serialize(customerData))*/;
            // Access service and then send the customerData into the AddCustomer function
            // Terminate connection
            CustomerService customerService = new CustomerService();
            customerService.AddCustomer(customerData);
            customerService.Dispose();

            return Ok("Success");
        }

        public IActionResult UpdateCustomer([FromBody] Customers customerData)
        {
            // Access service and then send the customerData into the UpdateCustomer function
            // Terminate connection
     
            CustomerService customerService = new CustomerService();
            customerService.UpdateCustomer(customerData);
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

    /*public class Customer
    {
        public string? Customer_ID { get; set; }
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public string? Email { get; set; }
        public string? Phone_Number { get; set; }
        public string? Address { get; set; }
    }*/
}