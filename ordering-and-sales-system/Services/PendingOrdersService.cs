using ordering_and_sales_system.Domain.Repositories;
using ordering_and_sales_system.Models;
using ordering_and_sales_system.Domain.Entities;
using ordering_and_sales_system.Domain.DataTransferObject;
using ordering_and_sales_system.Infrastracture; // Corrected typo in "Infrastracture"
using System;
using System.Collections.Generic;

namespace ordering_and_sales_system.Services
{
    public class PendingOrdersService : IDisposable
    {
        private readonly CustomerRepository customerRepository;
        private readonly InventoryRepository inventoryRepository;
        private readonly PendingOrdersRepository pendingOrdersRepository;

        public PendingOrdersService()
        {
            customerRepository = new CustomerRepository();
            inventoryRepository = new InventoryRepository();
            pendingOrdersRepository = new PendingOrdersRepository();

            Model = new PendingOrdersModel();
            GetAllCustomerList(); // Corrected method invocation
            GetAllInventoryList(); // Corrected method invocation
        }

        public PendingOrdersModel Model { get; set; }

        public void GetAllCustomerList() // Changed return type to void
        {
            Model.CustomerList = customerRepository.GetAllCustomers();
        }

        public PendingOrdersModel GetAllInventoryList() // Changed return type to void
        {
            List<Inventory> inventory = inventoryRepository.GetAllInventory();

            List<InventoryDataTransferObject> productData = new List<InventoryDataTransferObject>();

            foreach (Inventory product in inventory)
            {
                InventoryDataTransferObject inventoryDataTransferObject = new InventoryDataTransferObject(product);
                productData.Add(inventoryDataTransferObject);
            }
       /*     Model.InventoryList = productData;*/
            return Model;
        }

        public void Dispose()
        {
            customerRepository.Dispose();
            inventoryRepository.Dispose();
            pendingOrdersRepository.Dispose();
        }
    }
}


