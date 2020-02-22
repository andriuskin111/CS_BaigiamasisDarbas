using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinesLogic;

namespace WarehouseManagementUI
{
    public class InfoDisplay
    {
        public void ShowAllOrders(ReportGenerator reportGenerator)
        {
            foreach (var report in reportGenerator.GenerateReport())
            {
                Console.WriteLine($"Order Id: {report.OrderId}\n" +
                    $"Date: {report.OrderDate}\n" +
                    $"Customer: {report.Customer}\n" +
                    $"Status: {report.OrderStatus}\n" +
                    $"Parts:\n{report.Parts}");
            }
        }

        public void ShowOrdersById(ReportGenerator reportGenerator, int orderId)
        {
            foreach (var report in reportGenerator.GenerateReport(orderId))
            {
                Console.WriteLine($"Order Id: {report.OrderId}\n" +
                    $"Date: {report.OrderDate}\n" +
                    $"Customer: {report.Customer}\n" +
                    $"Status: {report.OrderStatus}\n" +
                    $"Parts:\n{report.Parts}");
            }
        }

        public void ShowOrdersByDate(ReportGenerator reportGenerator, DateTime date)
        {
            foreach (var report in reportGenerator.GenerateReport(date))
            {
                Console.WriteLine($"Order Id: {report.OrderId}\n" +
                    $"Date: {report.OrderDate}\n" +
                    $"Customer: {report.Customer}\n" +
                    $"Status: {report.OrderStatus}\n" +
                    $"Parts:\n{report.Parts}");
            }
        }

        public void ShowOrdersByCustomer(ReportGenerator reportGenerator, string customer)
        {
            foreach (var report in reportGenerator.GenerateReport(customer))
            {
                Console.WriteLine($"Order Id: {report.OrderId}\n" +
                    $"Date: {report.OrderDate}\n" +
                    $"Customer: {report.Customer}\n" +
                    $"Status: {report.OrderStatus}\n" +
                    $"Parts:\n{report.Parts}");
            }
        }

        public void ShowOrdersByStatus(ReportGenerator reportGenerator, string status)
        {
            foreach (var report in reportGenerator.GenerateReportOrderStatus(status))
            {
                Console.WriteLine($"Order Id: {report.OrderId}\n" +
                    $"Date: {report.OrderDate}\n" +
                    $"Customer: {report.Customer}\n" +
                    $"Status: {report.OrderStatus}\n" +
                    $"Parts:\n{report.Parts}");
            }
        }

        public void ShowPartsInStock(PartRepository partRepository)
        {
            Console.WriteLine($"Parts in stock({partRepository.Retrieve().Count}):");

            foreach (var part in partRepository.Retrieve())
            {
                Console.WriteLine($"Part Id: {part.Id}" +
                    $", Code: {part.Code}" +
                    $", Brand: {part.Brand}" +
                    $", Model: {part.Model}" +
                    $", Description: {part.Description}" +
                    $", Location: {part.Location.Code} {part.Location.Description}");
            }

            Console.WriteLine();
        }

        public void ShowAvailablePartsInStock(OrderController orderController, PartRepository partRepository)
        {
            Console.WriteLine("Available parts in stock");

            foreach (var part in orderController.GetAvailableParts(partRepository))
            {
                Console.WriteLine($"Part Id: {part.Id}" +
                    $", Code: {part.Code}" +
                    $", Brand: {part.Brand}" +
                    $", Model: {part.Model}" +
                    $", Description: {part.Description}" +
                    $", Location: {part.Location.Code} {part.Location.Description}");
            }

            Console.WriteLine();
        }

        public void ShowPartsByLocationCode(PartRepository partRepository, string locationCode)
        {
            int partCount = 0;

            Console.WriteLine($"Parts in stock({partRepository.Retrieve().Count}):");

            foreach (var part in partRepository.Retrieve())
            {
                if(locationCode == part.Location.Code)
                {
                    Console.WriteLine($"Part Id: {part.Id}" +
                    $", Code: {part.Code}" +
                    $", Brand: {part.Brand}" +
                    $", Model: {part.Model}" +
                    $", Description: {part.Description}" +
                    $", Location: {part.Location.Code} {part.Location.Description}");

                    partCount++;
                }
            }

            if(partCount == 0)
            {
                Console.WriteLine($"Location {locationCode} is empty!");
            }

            Console.WriteLine();
        }
    }
}
