using Microsoft.AspNetCore.Mvc;
using NWFrontEndApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace NWFrontEndApp.Controllers
{
    public class CustomersController : Controller
    {
        private static List<Customer> customers =
        [
            new Customer { CustomerId = 1, CompanyName = "Company A", ContactName = "John Doe", Phone = "123-456", Fax = "987-654", Country = "USA" },
            new Customer { CustomerId = 2, CompanyName = "Company B", ContactName = "Jane Smith", Phone = "321-654", Fax = "876-543", Country = "USA" },
            new Customer { CustomerId = 3, CompanyName = "Company C", ContactName = "Maria Lopez", Phone = "555-123", Fax = "555-321", Country = "Mexico" }
        ];

        private static List<Order> orders =
        [
            new Order { OrderId = 1, CustomerId = 1, OrderDate = new DateTime(2023, 1, 15), ShippedDate = new DateTime(2023, 1, 20), ShipAddress = "123 Main St" },
            new Order { OrderId = 2, CustomerId = 1, OrderDate = new DateTime(2023, 2, 10), ShippedDate = new DateTime(2023, 2, 15), ShipAddress = "123 Main St" },
            new Order { OrderId = 3, CustomerId = 2, OrderDate = new DateTime(2023, 1, 20), ShippedDate = new DateTime(2023, 1, 25), ShipAddress = "456 Oak St" }
        ];

        // Action to display customers by country
        public IActionResult CustomersByCountry(string country)
        {
            var filteredCustomers = customers
                .Where(c => string.IsNullOrEmpty(country) || c.Country.Contains(country, StringComparison.OrdinalIgnoreCase))
                .OrderBy(c => c.ContactName)
                .ToList();

            return View(filteredCustomers);
        }

        // Action to display orders for a specific customer
        public IActionResult CustomerOrdersInformation(int id)
        {
            var customerOrders = orders
                .Where(o => o.CustomerId == id)
                .OrderBy(o => o.ShippedDate)
                .ToList();

            return View(customerOrders);
        }
    }
}
